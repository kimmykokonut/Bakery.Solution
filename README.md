# Project Name
_by Kim Robinson_

## Description

###  This app will allow a user to:
    -
    -


### Technologies Used

* C#
* MSTest
* TDD (Test Driven Development)
* RGR Workflow (Red Green Refactor)
* .Net
* Git
* NuGet package with dotnet CLI

## Setup/Installation Requirements

_This is a basic console application, not viewable on gh-pages. Please follow steps below to set up locally_

1. Navigate to [my github repository](https://github.com/kimmykokonut/XXX) for this project 

2. Click the `Fork` button and  you will be taken to a new page where you can give your repository a new name and description. Choose "create fork".

3. Click the `Code` button and copy the url for HTTPS.

4. On your local computer, create a working directory for my files and name appropriately.

5. On your terminal, type `$ git clone 'url'` (using the url from step 3.)

6. Once you have this on your local directory, if you ever want to push it to GitHub, you need to do these steps first so Git knows to ignore the obj and bin directories:
`$ git init` to initialize Git 
`$ touch .gitignore` adds .gitignore file in the root directory. add bin and obj to this file and save.
`$ git add .gitignore`
`$ git commit -m 'add .gitignore`
`$ git push origin main`

7. On your terminal, type `$ code .` to open in VS Code.  If you do not have VS Code Editor, you may download [here](https://code.visualstudio.com/)

8. Once in VS Code, open the terminal and navigate to the project's production directory called "XXX" and type `$ dotnet build` to compile the application's code.

9.  To use MSTest, you need to use the NuGet package manager to install the packages in the .csproj file.  Navigate to the .Tests directory in the terminal and run the command `$ dotnet restore`

9.  Optionally you can use a file watcher so you don't have to restart the server every time the code changes. Run this command `$ dotnet watch run` to make the server automatically update.

10. In the terminal, type `$ dotnet run` (to compile and execute the console application ). Since this is a console application, you'll interact with it through text commands in your terminal.

11. Enjoy my first solo official C# Console Application!  You can exit the program at anytime by entering `ctrl` + `c` at any time.

* To run tests using MSTest, navigate to the .Tests directory in your terminal and type `$ dotnet test`

## Known Bugs
* None known at this time

## License
MIT License. See license.md for further information