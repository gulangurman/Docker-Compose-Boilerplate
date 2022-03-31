# Docker Compose Boilerplate
A boilerplate MS Visual Studio solution that has orchestration support with Docker Compose.

The solution includes:
  - A simple MVC project to serve as an e-commerce microservice
  - A MongoDB container to serve as the private data store for the e-commerce microsevice
  
To start the containers:
    
    docker-compose -f docker-compose.yml -f docker-compose.override.yml up -d
    
