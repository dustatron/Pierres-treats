# _Pierre's Treats_

#### _Epicodus 2020 C#/React Friday Project._

#### By _** Dusty Mccord | March 27, 2020**_

## Description

This program will allow a user to see the treat and flavor options at a fictional bakery. When a user logins in they will be able add, update and delete both flavors and treats. 

## Specifications:
### CRUD Functionality 

| Behavior | Input | Output |
|---|:---:|:---:|
| When user opens the application they have a choice to see all Treats or see all Flavors from the Navbar | Home | "Treats", "Flavors."|
| When a user clicks "Flavors", they are provided with a list of all Flavors | Click: "Flavors" | "Flavors:" "Flavor1", "Flavor2" OR "Add New Flavor"|
| When a user clicks on "Add A New Flavor", they are directed to a form to add a new Flavor | Cick: "Add A New Flavor | "Add A New Flavor" Name: "Input Name" |
| When a User Adds a new Flavor Name they are directed back to the Flavors Index page | Name: "Sweet" Submit: "Add New Flavor" | Flavors: "Sweet" |
| When a user clicks on a Flavor name, they are directed to a list of Treats of with that Flavor | Click: "Sweet" | Flavor Details: "List of Treats:" |
| From the Flavor Details Page, when a user click on "Edit Flavor", they are directed to a Edit Page Form | Click: "Edit Flavor" | Edit: "Sweets II" |
| When a user clicks on "Delete Flavor," they are directed to a confirmation page | Click: "Delete Flavor" | "Are you sure you want to delete this?" |
| When the user clicks on the name of a treat. They are directed to the detail page for that treat | Click: "treat Name" | "treat Name Deatails: |
| From the treat Details Page, when the user clicks "Edit treat Details", they are directed to an Treat/Edit Page | Click: "Edit treat Details" | Edit "treat Name" with Edit Form |
| After the User Submits the edit form, they are directed back to the treat Details page | Click: "Save Changes" | treat Index | 
| From the treat Details Page, when the user clicks on Delete this treat, they are directed to a confirmation page | Click: "Delete This treat" | "Are you sure you want delete 'treat Name' |

###Authentication
| Behavior | Input | Output |
|---|:---:|:---:|
| From the home page a user can click Account from the Navbar and they will be presented with Register, Log in, Home. User If user click on register they will be taken to a form to start an account | "Click Register" | show form to start new accoutn | 
| From registration form a user should be able to enter in an email and password and then click register and the app will return user to home page | Enter email, password, click register | show home page |
| A user should be able to click on Account in the Navbar and then click on login. The user should see a form that prompts the user to enter an email and password. When the user enter their details they can click login and they should be taking to the index page. | enter email, password, then click login | see home page |
| When the user is logged in they should be able to click on Account and see a message that says hello "User user@gmail.com" | click account | "hello User@email.com" |
| When a user is logged in and they click on account from the Navbar they should they should see a button that says 'log out.' when they click log out it should redirection them home. | click log out | show home page. |


## Setup/Installation Requirements

### Install .NET Core

#### on macOS:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download a .NET Core SDK from Microsoft Corp._
* _Open the file (this will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.)_

#### on Windows:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp._
* _Open the .exe file and follow the steps provided by the installer for your OS._


### Install MySQL and MySQL Workbench

#### on macOS:
_Download the MySQL Community Server DMG File [here](https://dev.mysql.com/downloads/file/?id=484914). Follow along with the installer until you reach the configuration page. Once you've reached Configuration, set the following options (or user default if not specified):_
* use legacy password encryption
* set password (and change the password field in appsettings.json file of this repository to match your password)
* click finish
* open Terminal and enter the command ``echo 'export PATH="/usr/local/mysql/bin:$PATH"' >> ~/.bash_profile`` if using Git Bash.
* Verify MySQL installation by opening Terminal and entering the command ``mysql -uroot -p{your password here, omitted brackets}``. If you gain access to the MySQL command line, installation is complete. An error (e.g., -bash: mysql: command not found) indicates something went wrong.

_Download MySQL Workbench DMG file [here](https://dev.mysql.com/downloads/file/?id=484391). Install MySQL Workbench to Applications folder. Open MySQL Workbench and select Local instance 3306 server, then enter the password you set. If it connects, you're all set._

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
* Open MySQL Workbench and select Local instance 3306 server (may be named differently). Enter the password you set, and if it connects, you're all set.

### Clone this repository

_Enter the following commands in Terminal (macOS) or PowerShell (Windows):_
```sh
cd desktop
```
```sh
git clone https://github.com/dustatron/Pierres-treats.git
```

_Confirm there you will have to navigated to the new directory by typing:_
```sh
 cd Pierres-treats
```

_Recreate the ``Dusty_McCord_db`` database with the following Command:_

```sh
 dotnet ef database update
```

_Now you should be able to start the app by entering the command:_
```sh
dotnet run
```



_To view/edit the source code of this application, open the contents of the Pierres-treats directory in a text editor or IDE of your choice (e.g., to open all contents of the directory in Visual Studio Code on macOS, enter the command_ ``code .`` _in Terminal)._

## Technologies Used
* _Git_
* _HTML_
* _CSS_
* _C#_
* _.NET Core 2.2_
* _ASP.NET Core MVC (version 2.2)_
* _Razor_
* _dotnet script_
* _MySQL 8.0 CE_
* _MySQL Workbench 8.0 CE_
* _Entity Framework Core 2.2_
* _Michelle Mornin README Template_

### License

*This webpage is licensed under the MIT license.*

Copyright (c) 2020 **_Dusty Mccord_**