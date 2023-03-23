# _Factory Tracker_

#### By _Geoffrey Gao_

#### _An application that helps to track factory engineer and machines_

## Technologies Used

* _C#_
* _ASP.Net Core MVC_
* _Entity Framework Core_
* _MySQL_

## Description

_This application contains a website that allows a user to track engineers and machines at a factory. The application contains functionality to add, view, and delete engineers and machines. The application allows users to assign engineers to machines and vice versa. The project demonstrates solid understanding of the new concepts from the Many-to-many relationships including MVC, SQL, and Entity Framework Core._

## Setup/Installation Requirements

* _Clone this repository_
* _Open your shell (e.g., Terminal or GitBash) and navigate into the "Factory" production directory_
  - _Within the production directory "Factory", create a new file called `appSettings.json`. Within this file, put in the following code, replacing the `uid` and `pwd` values with your own username and password for MySQL_
```JSON
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=factory;uid=root;pwd=[PASSWORD];"
  }
}
```
* _Create the database using the migrations in the To Do List project. Open your shell (e.g., Terminal or GitBash) to the production directory "Factory", and run `dotnet ef database update`._ 
* _In the terminal, run the program with `dotnet watch run` to start the project in development mode with a watcher_
* _If the application does not automatically launch, open the browser to [https://localhost:5001](https://localhost:5001)_

## Known Bugs

* _N/A_

## License

_MIT_

Copyright (c) _2023_ _Geoffrey Gao_