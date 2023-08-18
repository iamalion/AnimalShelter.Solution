# _Animal Shelter API_

#### By _**Lindsay Warr**_

#### _API for animal shelter cats and dogs built with C#, ASP.NET Core, and MySQL_

## Table of Contents

* [Technologies Used](#technologies-used)
* [Description](#description)
* [Setup & installation](#setupinstallation-requirements)
* [Endpoints](#endpoints)
* [Optional Query Parameters for GET](#optional-query-string-parameters-for-get-requests)
* [Example Get Requests](#example-get-requests)
* [Requirements for POST](#additional-requirements-for-post-requests)
* [Requirements for PUT and DELETE](#additional-requirements-for-put-and-delete-requests)
* [Known-bugs](#known-bugs)
* [License](#license)


## Technologies Used

* Git
* C#/.NET version 6.0.402
* MySQL Workbench
* Enity Framework Core version 6.0.0
* Swashbuckle version 6.2.3
* Postman / Swagger UI

## Description

AnimalShelterAPI is an API used to track animals for a local animal shelter. The database is seeded with data for 20 animals, and API supports full CRUD functionality to add additional animals and to edit and remove existing ones.

## Setup/Installation Requirements

* Clone this repository
* Open your shell (e.g., Terminal or GitBash) and navigate to this project's production directory `AnimalShelterApi``

#### To Configure and Access the Database:
* Within the production directory `AnimalShelterApi`, create a new file called `appsettings.json`._
* In `appsettings.json`, add the following code, replacing the "uid" and "pwd" values (in the brackets) with your own username and password for MySQL Workbench. Also replace the "database" value with your desired database name.
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=[DATABASE_NAME];uid=[USERNAME];pwd=[PASSWORD];"
  }
}
```
* Run the follwing commands 
`dotnet ef migrations add Initial`
`dotnet ef database update` 
to create the initial MySQL database.

#### To Run the API:
* Navigate to this project's production directory `AnimalShelterApi`
* Run the command `dotnet watch run` in the command line to run the API from your local port. This will also open up Swagger UI in your browser. 

#### Use Swagger UI to test an API call (optional):
* Open your browser and navigate to the Swagger UI tab.
* Click the "Execute" button to send requests, then scroll down to see your results. A successful response will return a status code 200 as well as a response body.
* Reference the different endpoint urls, optional parameters, and example requests listed below. The AnimalShelter API supports Get, Post, Update, and Delete functionality.

## Endpoints
```
GET https://localhost:5001/api/animals/
GET https://localhost:5001/api/animals/{id}
POST https://localhost:5001/api/animals/
PUT https://localhost:5001/api/animals/{id}
DELETE https://localhost:5001/api/animals/{id}
```
* Note: `{id}` is a variable and it should be replaced with the id number of the animal you want to GET, PUT, or DELETE.


## Example GET Requests


## Example PUT and DELETE Requests


## Known Bugs

* Versioning is a WIP

## License

_MIT License_

Copyright (c) 2023 Lindsay Warr