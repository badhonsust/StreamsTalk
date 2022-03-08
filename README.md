---
project: StreamsTalk Test API with The Clean Architecture Framework
platforms: asp.net core 5.0
author: badhon ashfaQ
---

# StreamsTalk Test API
This repo contains the code for StreamsTalk TCAF Session.This is an API project which is Implemented By the [Clean Architecture Framework](https://blog.cleancoder.com/uncle-bob/2012/08/13/the-clean-architecture.html) by using Generic Repository Pattern.


## Tech Stack:
+ ASP.NET Core 5.0
+ The Clean Architecture Framework
+ Generic Repository Pattern
+ Swagger for API Documentation
+ Microsoft SQL Server 2016
+ Entiy Framework Core Code First Approach With Migration

## Running the project
+ Clone the source code from github: `https://github.com/badhonsust/StreamsTalk.git`
+ Open the `.sln` file on your visual studio
+ Expand `StreamsTalk.API` Folder and open the `appsettings.json` file
+ Change the `StreamsTalkDbConnection` value to your database connection string
+ Open the `Packacge Manager Console` 
+ Run `Update-Database` Command
+ Run the project & it will open the Swagger Documentation page on the browser
