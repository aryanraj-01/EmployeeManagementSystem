# Employee Management System (Windows Forms .NET)

## Overview

Employee Management System is a desktop application built using C# and Windows Forms.
The application allows users to manage employees with full CRUD functionality and persistent JSON storage.

This project demonstrates desktop application development, data binding, file persistence, and clean UI interaction.

## Features

* Add employee
* Update employee
* Delete employee
* Search employee
* DataGridView binding
* JSON file persistence
* Auto ID generation
* Department dropdown selection
* Input validation
* Row click edit
* Double click edit
* Clear form
* Data reload on application start

## Technologies Used

* C#
* .NET Windows Forms
* LINQ
* JSON Serialization
* Newtonsoft.Json
* DataGridView
* Visual Studio

## Project Structure

EmployeeManagementSystem
│
├── Form1.cs
├── Employee.cs
├── employees.json
├── Program.cs
└── README.md

## How to Run

1. Clone the repository
2. Open solution in Visual Studio
3. Restore NuGet packages
4. Run the application

## Functionality

### Add Employee

Enter name, salary, and department then click Add.

### Update Employee

Select employee from grid, modify values, click Update.

### Delete Employee

Select employee and click Delete.

### Search Employee

Enter name and click Search.

### Persistence

All data is saved automatically to employees.json file.

## Learning Outcomes

This project demonstrates:

* Windows Forms UI development
* CRUD operations
* Data binding
* LINQ queries
* JSON serialization
* File handling
* Desktop application architecture
* Input validation
* State persistence

## Future Improvements

* Database integration (SQL Server)
* Export to Excel
* Login system
* Role-based access
* Reporting dashboard
* Pagination
* Advanced filtering

## Author

Developed as part of .NET desktop application learning path.
