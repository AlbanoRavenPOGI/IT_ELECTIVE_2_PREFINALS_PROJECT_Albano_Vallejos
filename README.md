# HelpDesk System

A custom ASP.NET Core MVC web application built with Entity Framework Core and SQLite to manage customer support tickets, categories, departments, and employee assignments.

## Prerequisites & Tech Stack

* **.NET Version:** .NET 8.0 (SDK)
* **ORM:** Entity Framework Core 8.0.x
* **Database Engine:** SQLite
* **Architecture Pattern:** Model-View-Controller (MVC)

## Installed NuGet Packages

* `Microsoft.EntityFrameworkCore.Sqlite` (v8.0.x)
* `Microsoft.EntityFrameworkCore.Design` (v8.0.x)
* `Microsoft.EntityFrameworkCore.Tools` (v8.0.x)

## Database Configuration

* **Database File Name:** `lycevm.db` (SQLite Database File)
* **Location:** Root directory of the project (`./lycevm.db`)
* **Connection String:** Configured inside `appsettings.json`:
  ```json
  "ConnectionStrings": {
    "DefaultConnection": "Data Source=lycevm.db"
  }

## How to Run

Using Visual Studio 2022
* Clone or download this project repository to your local machine.
* Open HelpDesk_System.sln using Visual Studio 2022.
* Ensure HelpDesk_System is set as the Startup Project.
* Press F5 (or click the green Play button with https/IIS Express) to build and launch the application in your default web browser.
