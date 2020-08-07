#  _Factory_

#### _A Collection of Machine and Engineers_
##### __Created:__ 8/7/2020
##### __Last Updated:__ 8/7/2020 
##### By _**Chris Yoon**_  

## Description

_Keep track of your Engineers and Machines with a click of a button. Save time with this data management program that syncs your engineers with the machines they are qualified to operate._

## Behaviors

| Spec| Example input | Example Output
| ----------- | ----------- | ----------- |
| The program takes a user input of a Machine and Machine Details as well as an engineer if there is an engineer | "Machine: Wild Thing, "Roller" Engineer:"Steve" | N/A |
| The program allows user to EDIT Machine entry | N/A | N/A |
| The program allows user to DELETE Machine entry | N/A | N/A |
| The program displays user inputs of Machine and Engineer | N/A | "-Steve, Machine: Wild Thing"|
| The program takes a user input of a Engineer and Engineer Details as well as a Machine the engineer can operate if there is a machine | "Name: Pat, "Mechanical engineer" "Machine: Wild Thing | N/A |
| The program allows user to EDIT engineer entry | "N/A"  | N/A |
| The program allows user to DELETE engineer entry | N/A | N/A |

## Setup/Installation Requirements

#### Open via Bash/GitBash:

1. Clone this repository onto your computer:
    "git clone https://github.com/chyoon2/Factory.Solution"
2. Navigate into the "Factory.Solution" directory in Visual Studio Code or preferred text editor:
3. Open the project
    "code ."
4. Open your computer's terminal and navigate to the directory bearing the name of the program and containing the top level subdirectories and files.
5. Enter the command "dotnet build" in the terminal and press "Enter".
6. Enter the command "dotnet watch run" in the terminal and press "Enter".

##### Configue Appsettings.json Database:
1. Create an 'appsettings.json' file in your root folder.
2. Add the following code
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=FIRSTNAME_LASTNAME;uid=root;pwd=YOURPASSWORD"
  }
}
```
3. In the YOURPASSWORD, add your password, if you're with epicodus enter 'epicodus'.
4. This program's database name is set to lowercase 'chris_yoon'

##### Configure Migration:
1. In your terminal run 'dotnet ef migrations add Initial'
2. Then run 'dotnet ef database update'
3. Refresh your Sql workbench to check for the 'chris_yoon' schema. You may have named it differently.

## Known Bugs

* When submitting an edit/update the program adds another engineer/machine into the list.

## Support and contact details
Reach out to chy.yoon@gmail.com for support.

## Technologies Used

* Visual Studio Code
* HTML
* CSS
* Bootstrap
* C#
* MVC
* MySQL Workbench
* Entity Framework
* .NET Core

## Resources:
* Image used: ![Image of dr.suess machine](https://i.pinimg.com/originals/54/e6/4b/54e64be199df9746546d2b94d3ee54d4.jpg)
### License

Copyright (c) 2020 ** _Chris Yoon_**

This software is licensed under the MIT license.