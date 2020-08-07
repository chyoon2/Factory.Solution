#  _Factory_

#### _A Collection of Machine and Engineers_
##### __Created:__ 8/7/2020
##### __Last Updated:__ 8/7/2020 
##### By _**Chris Yoon**_  

## Description

_Keep track of your Engineers and Machines with a click of a button. Save time with this data management program that syncs your engineers with the machines they are qualified to Operate._

## Behaviors

| Spec| Example input | Example Output
| ----------- | ----------- | ----------- |
| The program takes a user input of a Stylist
name and their Date of Hire | "Name: John, Date of Hire: June 1, 2020" | N/A |
| The program allows user to EDIT Stylist input. | "Name John Pats , Date of Hire: June 1, 2020" | N/A |
| The program allows user to DELETE Stylist | N/A | N/A |
| The program displays user inputs of Stylist and Client | N/A | "Pat: Stylist John"|
| The program takes a user input of a Client name, number, membership date, and stylist | "Name: Pat, Phone Number: 555-555-5555, Member Since: 1/1/2010" | N/A |
| The program allows user to EDIT Client input. | "Name: Spat, Phone Number: 555-555-5555, Member Since: 1/1/2010"  | N/A |
| The program allows user to DELETE Client | N/A | N/A |

## Setup/Installation Requirements


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
1. In your terminal run 'migration et ef Initial'
2. Then run 'migration et ef update'
3. Refresh your Sql workbench to check for the 'chris_yoon' schema. You may have named it differently.

Open via Bash/GitBash:

1. Clone this repository onto your computer:
    "git clone https://github.com/chyoon2/HairSalon.Solution"
2. Navigate into the "BestRestaurant" directory in Visual Studio Code or preferred text editor:
3. Open the project
    "code ."
4. Open your computer's terminal and navigate to the directory bearing the name of the program and containing the top level subdirectories and files.
5. Enter the command "dotnet build" in the terminal and press "Enter".
6. Enter the command "dotnet watch run" in the terminal and press "Enter".

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

### License

Copyright (c) 2020 ** Chris Yoon_**

This software is licensed under the MIT license.