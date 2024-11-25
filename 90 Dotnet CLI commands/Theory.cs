/*  .NET CLI

In the .NET CLI, dotnet is the driver, and commands fall into two main types:

-> Dotnet Command Structure

1. Application Command

-----------------------------------------------------------------------
dotnet [runtime options] [path to app] [args]
-----------------------------------------------------------------------

This is used to run a .NET application, often with specific runtime options.

2. SDK Command

-----------------------------------------------------------------------
dotnet [sdk options] [command] [command options] [args]
-----------------------------------------------------------------------

This is used to interact with the .NET SDK, managing projects, solutions, and packages.

-> Common Dotnet Commands

General Help

-----------------------------------------------------------------------
dotnet -h
-----------------------------------------------------------------------

Displays help for all available commands.

-> Basic Project and Solution Commands

1. Build Project

-----------------------------------------------------------------------
dotnet build
-----------------------------------------------------------------------

Builds the project in the current directory. Creates the bin directory with build outputs.

2. Clean Build Outputs

-----------------------------------------------------------------------
dotnet clean
-----------------------------------------------------------------------

Cleans the build outputs of a .NET project, removing files from the bin and obj directories.

3. Run Project

-----------------------------------------------------------------------
dotnet run
-----------------------------------------------------------------------

Runs the main project in the current directory. Must be in a project folder to execute.

4. Create .gitignore

-----------------------------------------------------------------------
dotnet new gitignore
-----------------------------------------------------------------------

Creates a .gitignore file tailored for .NET projects.

5. List Available Templates

-----------------------------------------------------------------------
dotnet new list
-----------------------------------------------------------------------

Lists all templates available for creating new projects, classes, or files.

6. Create New Solution

-----------------------------------------------------------------------
dotnet new sln -n SolutionName
-----------------------------------------------------------------------

Creates a new solution file in the specified directory with SolutionName as the name.

7. List Projects in Solution

-----------------------------------------------------------------------
dotnet sln list
-----------------------------------------------------------------------

Lists all the projects currently added to the solution.

8. List Project References

-----------------------------------------------------------------------
dotnet list ProjectName reference
-----------------------------------------------------------------------

Lists all references (e.g., other projects, packages) for a given project.

-> Adding and Removing Packages

1. Add Package to Project

-----------------------------------------------------------------------
dotnet add ProjectName package PackageName
-----------------------------------------------------------------------

Adds the specified NuGet package (PackageName) to ProjectName.

2. Remove Package from Project

-----------------------------------------------------------------------
dotnet remove ProjectName package PackageName
-----------------------------------------------------------------------

Removes the specified package from the project by removing it from the <ItemGroup></ItemGroup> in the project file.

-> Creating Projects and Libraries

1. Create Console Project

-----------------------------------------------------------------------
dotnet new console -o DemoApp
-----------------------------------------------------------------------

Creates a new console application in the DemoApp folder, naming the project DemoApp.

2. Add Project to Solution

-----------------------------------------------------------------------
dotnet sln add DemoApp
-----------------------------------------------------------------------

Adds the DemoApp project to the solution file.

3. Create Class Library

-----------------------------------------------------------------------
dotnet new classlib -o DemoLib
-----------------------------------------------------------------------

Creates a new class library in the DemoLib folder.

4. Add Class Library to Solution

-----------------------------------------------------------------------
dotnet sln add DemoLib
-----------------------------------------------------------------------

Adds the DemoLib class library to the solution.

-> Managing Dependencies and References

1. Add NuGet Package

-----------------------------------------------------------------------
dotnet add package Dapper
-----------------------------------------------------------------------

Adds the latest version of the Dapper NuGet package to the project. This command must be run from the project folder.

2. Add Project Reference

-----------------------------------------------------------------------
dotnet add reference ../DemoLib/DemoLib.csproj
-----------------------------------------------------------------------

Adds a reference to the DemoLib project within another project, such as DemoApp.

3. Restore Packages

-----------------------------------------------------------------------
dotnet restore
-----------------------------------------------------------------------

Ensures all required NuGet packages are installed for the project, often necessary after cloning a repository.

-> Publishing Projects

1. Basic Publish

-----------------------------------------------------------------------
dotnet publish
-----------------------------------------------------------------------

Publishes the application, creating an executable in the publish folder. By default, includes necessary dependencies.

2. Publish Single File

-----------------------------------------------------------------------
dotnet publish -p:PublishSingleFile=true
-----------------------------------------------------------------------

Publishes the application as a single executable file, simplifying deployment.

3. Publish for Specific Runtime

-----------------------------------------------------------------------
dotnet publish -p:PublishSingleFile=true -r win-x64
-----------------------------------------------------------------------

Specifies the target runtime (win-x64 in this case) for the executable.

4. Publish without .NET Runtime

-----------------------------------------------------------------------
dotnet publish -p:PublishSingleFile=true -r win-x64 --self-contained false
-----------------------------------------------------------------------

Publishes the application executable without bundling the .NET runtime, requiring it to be installed on the target machine.

5. Publish with .NET Runtime

-----------------------------------------------------------------------
dotnet publish -p:PublishSingleFile=true -r win-x64 --self-contained true
-----------------------------------------------------------------------

Publishes an executable with the .NET runtime included, allowing it to run on systems without .NET installed.

*/

/*  DotNet commands for MVC

The .NET CLI (Command-Line Interface) provides commands to create, build, run, publish, and manage .NET applications, including ASP.NET MVC projects. Here’s a detailed overview of the key .NET CLI commands for working with MVC applications, from creating a new project to managing dependencies and publishing.

1. Creating a New ASP.NET MVC Project

-------------------------------------------------------------------------------------------------------------------
 dotnet new mvc: This command creates a new ASP.NET Core MVC project with the standard MVC template (Model-View-Controller).

 -o MyMvcApp: The -o option specifies the output directory. In this case, it creates a folder named MyMvcApp where the project will be initialized.
-------------------------------------------------------------------------------------------------------------------

2. Project Management Commands

(i) Initialize a New .NET Project

-------------------------------------------------------------------------------------------------------------------
dotnet new
-------------------------------------------------------------------------------------------------------------------

Shows all available templates. You can use this command to view the options for MVC templates and others.

(ii) Add Project References

-------------------------------------------------------------------------------------------------------------------
dotnet add reference ../MyOtherProject/MyOtherProject.csproj
-------------------------------------------------------------------------------------------------------------------

dotnet add reference: Adds a reference to another .NET project. This is commonly used when you want to reference shared libraries or helper projects in your MVC application.

(iii) Remove a Package

-------------------------------------------------------------------------------------------------------------------
dotnet remove package <package-name>
-------------------------------------------------------------------------------------------------------------------

dotnet remove package: Removes an existing package from the project.

(iv) List Installed Packages

-------------------------------------------------------------------------------------------------------------------
dotnet list package
-------------------------------------------------------------------------------------------------------------------

dotnet list package: Lists all NuGet packages currently installed in the project, along with their versions.

(v) Building the MVC Application

-------------------------------------------------------------------------------------------------------------------
dotnet build
-------------------------------------------------------------------------------------------------------------------

dotnet build: Compiles the MVC project, building the output files and placing them in the bin directory. It checks for syntax errors and ensures the code is ready to run or publish.

Build with Specific Configuration

-------------------------------------------------------------------------------------------------------------------
dotnet build -c Release
-------------------------------------------------------------------------------------------------------------------

-c Release: Builds the project in Release mode, which optimizes the application for deployment.

4. Running the MVC Application

-------------------------------------------------------------------------------------------------------------------
dotnet run
-------------------------------------------------------------------------------------------------------------------

dotnet run: Builds and runs the application in one step. By default, it runs in development mode.

Run with Specific Configuration

-------------------------------------------------------------------------------------------------------------------
dotnet run --configuration Release
-------------------------------------------------------------------------------------------------------------------

--configuration Release: Runs the application in Release mode for a production-like environment.

5. Testing

If you have test projects set up (e.g., using xUnit or MSTest), you can run the tests directly.

-------------------------------------------------------------------------------------------------------------------
dotnet test
-------------------------------------------------------------------------------------------------------------------

dotnet test: Runs all tests in the project. It’s helpful to run this before publishing to ensure your application functions as expected.

6. Publishing the MVC Application

-------------------------------------------------------------------------------------------------------------------
dotnet publish -c Release -o ./publish
-------------------------------------------------------------------------------------------------------------------

dotnet publish: Compiles and packages the application for deployment.

-c Release: Specifies Release mode for optimized production code.

-o ./publish: Specifies the output directory for the published files. In this example, it will publish to a publish folder within the project.

After publishing, the output directory will contain all necessary files to deploy the MVC app to a web server.

7. Project Information

You can view the details of the current project, such as the project type, SDK, target framework, and dependencies.

-------------------------------------------------------------------------------------------------------------------
dotnet --info
-------------------------------------------------------------------------------------------------------------------

dotnet --info: Displays information about the .NET installation, including the runtime and SDK version. Useful for verifying environment setup.

8. Global Tools

Global tools can be installed via the CLI and used across multiple projects.

(i) Install a Global Tool

-------------------------------------------------------------------------------------------------------------------
dotnet tool install -g <tool-name>
-------------------------------------------------------------------------------------------------------------------

dotnet tool install -g: Installs a global tool accessible from any project. Some common tools include dotnet-ef for Entity Framework and dotnet-watch for auto-reloading during development.

(ii) Update a Global Tool

-------------------------------------------------------------------------------------------------------------------
dotnet tool update -g <tool-name>
-------------------------------------------------------------------------------------------------------------------

dotnet tool update -g: Updates the specified global tool to the latest version.

(iii) List Installed Global Tools

-------------------------------------------------------------------------------------------------------------------
dotnet tool list -g
-------------------------------------------------------------------------------------------------------------------

dotnet tool list -g: Lists all global tools installed on your system.

9. Cleaning the Build Output

If you want to remove the previous build outputs, you can use the clean command:

-------------------------------------------------------------------------------------------------------------------
dotnet clean
-------------------------------------------------------------------------------------------------------------------

dotnet clean: Removes all the build outputs for the current project, typically used when switching configurations or resolving build issues.

10. Restoring Dependencies

To restore NuGet packages and project dependencies, use:

-------------------------------------------------------------------------------------------------------------------
dotnet restore
-------------------------------------------------------------------------------------------------------------------

dotnet restore: Downloads and installs missing dependencies and packages specified in the project’s .csproj file. This is automatically executed when you build, but it can be manually run to ensure all dependencies are in place.

11. Creating Class Libraries and Adding as Dependencies

If you’re working on a multi-project solution, you can create class libraries and reference them in your MVC project.

9i) Create a Class Library

-------------------------------------------------------------------------------------------------------------------
dotnet new classlib -o MyLibrary
-------------------------------------------------------------------------------------------------------------------

dotnet new classlib: Creates a new class library, which can be used as a reusable component across multiple projects.

(ii) Add the Class Library as a Dependency

-------------------------------------------------------------------------------------------------------------------
dotnet add reference ../MyLibrary/MyLibrary.csproj
-------------------------------------------------------------------------------------------------------------------

Adds a reference to the class library from the main MVC project.

12. Working with Entity Framework

Entity Framework Core provides its own CLI commands for managing migrations and database updates.

(i) Add a Migration

-------------------------------------------------------------------------------------------------------------------
dotnet ef migrations add <MigrationName>
-------------------------------------------------------------------------------------------------------------------

dotnet ef migrations add: Adds a new migration based on changes in the model classes.

(ii) Update Database

-------------------------------------------------------------------------------------------------------------------
dotnet ef database update
-------------------------------------------------------------------------------------------------------------------

dotnet ef database update: Applies the latest migration(s) to the database, syncing it with the current model state.

(iii) Remove a Migration

-------------------------------------------------------------------------------------------------------------------
dotnet ef migrations remove
-------------------------------------------------------------------------------------------------------------------

dotnet ef migrations remove: Removes the most recent migration.
Note: Ensure dotnet-ef is installed as a global tool to access these commands.

13. Working with Solution Files

If you’re working on a larger application with multiple projects, you can manage them in a solution file.

(i) Create a Solution File

-------------------------------------------------------------------------------------------------------------------
dotnet new sln -o MySolution
-------------------------------------------------------------------------------------------------------------------

dotnet new sln: Creates a new solution file that can group multiple projects.

(ii) Add a Project to the Solution

-------------------------------------------------------------------------------------------------------------------
dotnet sln add <project-path>
-------------------------------------------------------------------------------------------------------------------

dotnet sln add: Adds a project to the solution file, making it easier to manage dependencies across projects.

(iii) List Projects in the Solution

-------------------------------------------------------------------------------------------------------------------
dotnet sln list
-------------------------------------------------------------------------------------------------------------------

dotnet sln list: Lists all projects currently in the solution file.

(iv) Remove a Project from the Solution

-------------------------------------------------------------------------------------------------------------------
dotnet sln remove <project-path>
-------------------------------------------------------------------------------------------------------------------

dotnet sln remove: Removes a project from the solution file.

-> Summary

These .NET CLI commands enable you to efficiently create, manage, build, test, run, and deploy MVC applications. The CLI supports end-to-end development, from creating new projects and managing dependencies to deploying the app, making it a powerful tool in the .NET ecosystem. Whether you’re working on a single MVC project or a complex solution, the .NET CLI simplifies many common development tasks, enhancing productivity.

*/
