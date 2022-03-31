using EStore.MVC.Data;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddControllers();

// setup product db: get settings from appsettings.json, pass on to the DI of the db context
builder.Services.Configure<ProductDbSettings>(builder.Configuration.GetSection(nameof(ProductDbSettings)));
builder.Services.AddSingleton<IProductDbSettings>(sp => sp.GetRequiredService<IOptions<ProductDbSettings>>().Value);
builder.Services.AddTransient<IProductContext, ProductContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
