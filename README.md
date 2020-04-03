# Businesses API

#### _Independent project on building an API_

#### By: **Kristina Hengster Tintor**, April 3, 2020

## Description

_This API allows users to GET, POST, PUT, and DELETE businesses of the cretaceous period._

## Specification user stories:
* A user is able to GET, POST, PUT, and DELETE businesses.
* A user is able to view details for a specific business, based on BusinessId.
* A user is able to GET businesses by name or description.
* A user is able to work with multiple versions of API. If 

## Endpoints:
### All endpoints have a host of 'localhost:5000' and base path of '/api'
* '/businesses'
  - GET request
  - returns list of all businesses matching search parameters name and/or description, or all businesses if no search parameters are used.
* '/businesses'
  - POST request, requires body of business object formatted in JSON
  - returns nothing, but adds an entry of an business to the ``kristina_hengster_tintor`` database table ``businesses``
* '/businesses/{id}'
  - GET request
  - returns details for a specific business
* '/businesses/{id}'
  - PUT request, requires a body of an business object formatted in JSON
  - returns nothing, but updates an existing entry in the ``businesses`` table of the ``kristina_hengster_tintor`` database
* '/businesses/{id}'
  - DELETE request
  - returns nothing, but removes an existing entry from the ``businesses`` table of the ``kristina_hengster_tintor`` database

## Setup/Installation Requirements

### Install .NET Core

#### on macOS:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download a .NET Core SDK from Microsoft Corp._
* _Open the file (this will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.)_

#### on Windows:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp._
* _Open the .exe file and follow the steps provided by the installer for your OS._

#### Install dotnet script
_Enter the command ``dotnet tool install -g dotnet-script`` in Terminal (macOS) or PowerShell (Windows)._

### Install MySQL

#### on macOS:
_Download the MySQL Community Server DMG File [here](https://dev.mysql.com/downloads/file/?id=484914). Follow along with the installer until you reach the configuration page. Once you've reached Configuration, set the following options (or user default if not specified):_
* use legacy password encryption
* set password (and change the password field in appsettings.json file of this repository to match your password)
* click finish
* open Terminal and enter the command ``echo 'export PATH="/usr/local/mysql/bin:$PATH"' >> ~/.bash_profile`` if using Git Bash.
* Verify MySQL installation by opening Terminal and entering the command ``mysql -uroot -p{your password here, omitted brackets}``. If you gain access to the MySQL command line, installation is complete. An error (e.g., -bash: mysql: command not found) indicates something went wrong.

#### on Windows:
_Download the MySQL Web Installer [here](https://dev.mysql.com/downloads/file/?id=484919) and follow along with the installer. Click "Yes" if prompted to update, and accept license terms._
* Choose Custom setup type
* When prompted to Select Products and Features, choose the following: MySQL Server (Will be under MySQL Servers) and MySQL Workbench (Will be under Applications)
* Select Next, then Execute. Wait for download and installation (can take a few minutes)
* Advance through Configuration as follows:
  - High Availability set to Standalone.
  - Defaults are OK under Type and Networking.
  - Authentication Method set to Use Legacy Authentication Method.
  - Set password to epicodus. You can use your own if you want but epicodus will be assumed in the lessons.
  - Unselect Configure MySQL Server as a Windows Service.
* Complete installation process

_Add the MySQL environment variable to the System PATH. Instructions for Windows 10:_
* Open the Control Panel and visit _System > Advanced System Settings > Environment Variables..._
* Select _PATH..._, click _Edit..._, then _Add_.
* Add the exact location of your MySQL installation and click _OK_. (This location is likely C:\Program Files\MySQL\MySQL Server 8.0\bin, but may differ depending on your specific installation.)
* Verify installation by opening Windows PowerShell and entering the command ``mysql -uroot -p{your password here, omitted brackets}``. It's working correctly if you gain access to the MySQL command line. Exit MySQL by entering the command ``exit``.

### Clone this repository

_Enter the following commands in Terminal (macOS) or PowerShell (Windows):_
* ``cd desktop``
* ``git clone`` followed by the URL to this repository
* ``cd BusinessesApi.Solution/BusinessesApi``

_Confirm that you have navigated to the BusinessesApi directory (e.g., by entering the command_ ``pwd`` _in Terminal)._

_Recreate the ``kristina_hengster_tintor`` database using the following commands (in Terminal on macOS or PowerShell on Windows) at the root of the BusinessesApi directory:_
* ``dotnet restore``
* ``dotnet build``
* ``dotnet ef database update``

_Run this application by entering the following command in Terminal (macOS) or PowerShell (Windows) at the root of the BusinessesApi directory:_
* ``dotnet run`` or ``dotnet watch run``
* With the API running, open the [Swagger UI](http://localhost:5000/swagger/index.html#/) to view and test the different routes of this API!

_To view/edit the source code of this application, open the contents of the BusinessesApi.Solution directory in a text editor or IDE of your choice (e.g., to open all contents of the directory in Visual Studio Code on macOS, enter the command_ ``code .`` _in Terminal at the root of the BusinessesApi.Solution directory)._

## Technologies Used

* Git 2.23.0
* C# language
* .NET Core 2.2.106
* dotnet script 0.50.1
* Visual Studio Code 1.43.1
* Model-View-Controller(MVC) framework
* MySQL 8.0.15
* MySQL Workbench 8.0.15
* Entity Framework Core 2.2.4
* Language-Integrated Query (LINQ)
* ASP.NET Razor
* GitBash
* Swagger 2.0 documentation (swagger.json)
* NSwag

## License

Licensed under the MIT license.

&copy; 2020 - Kristina Hengster Tintor