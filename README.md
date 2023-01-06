# B and C's Healthcare Office

## Contributors

* Chris Loveless
* Brandon Fenk

## Description
This project is a simple web application for a doctor's office to keep track of Doctors and their Patients. Doctors and Patients have a many to many relationship. A Doctors can have many clients. The application allows the user to create, update, delete, and view lists of the Doctors their patients. The app also includes a field to search for a doctor.

## Technologies Used

* _C#_
* _Html_
* _CSS_
* _ASP .NET6_
* _MySQL_
* _MVC_
* _Entity Framework Core_

## Setup/Installation Requirements

* Install MySQL Community Server and MySQL Workbench. Follow the instructions _[here](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql/)_.
* Clone down the git repo ```https://github.com/ChrisKLoveless/DoctorsOffice.Solution.git``` to the ```desktop``` directory
* Open the project with VSCode or a different source code editor.
* Restore required packages: change directory to ```DoctorsOffice``` and restore with ```$ dotnet restore```
* While in the ```DoctorsOffice``` directory use ```$ dotnet build``` to build the program.
* While in the ```DoctorsOffice``` directory use ```$ dotnet watch run``` to run the program in the browser with a watcher.

## Database Setup

* To connect your database, create file ```appsettings.json``` in the production directory ```DoctorsOffice```
* Fill in the file with the following code: Be sure to replace the required fields marked with ```[]``` that must contain the database name, user id, and password.
```
{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=[DB-NAME-HERE];uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
    }
}
```

## Known Bugs

* _Doctor Search functionality not working properly_
* If any bugs are found please email a brief description to: ```chriskloveless@gmail.com```

## License
Copyright (c) 2022 Chris Loveless and Brandon Fenk
_[MIT](https://choosealicense.com/licenses/mit/)_