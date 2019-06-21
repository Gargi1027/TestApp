--------------------------
DOT NET:
--------------------------
Create a new dotnet webapi project using cmd and oepn in VS Code

-dotnet new webapi -o OutputFilename.API -n ProjectName.API
-cd ProjectName.API
-code .

On the left side of VS code, use Extensions(bottom icon) to add the following extensions:
- C# for Visual Studio Code (Omnisharp)
- C# Extensions
- Nuget Package Manager
Hit reload on last installed extension for refreshing

In launchsettings.json, go to last setting (DEVELOPMENT) and change launchbrowser to false and remove http://localhost:5001

Open terminal in VS Code (ctrl+`) to run the project. 

Command to run the project: dotnet watch run

Models Class: Create new properties with getters and setters-> Prop ->tab

use ctls+. for quickfix menu lookup (when there is a red underline)

Create constructor: ctor ->tab

Create context for databse manipulation. Also, once the context is created, add it to services in startup.cs

For the current project, installed SQLlite using nuget package manager: In search, find nuget and select add package. In the next searchbar, search the package needed(here: Microsoft.EntityFrameworkCore.Sqlite)

Add ConnectionStrings to appsettings.json

Add cors services in startup.cs

Repository Pattern- to query database-> Interface and its implementation- Abstraction
why?: 1)Minimize duplicate query, 2)decouples application from persistance framework, 3)all db queries in same place, 4)promotes testability

Add repositories in startup class

Token- JWT(Json Web Tokens)- Structure:1) Header, 2)Payload, 3)Secret(SHA256)

Creating appsettings token in appsettings.json: Token should be super long, randomly generated for security purposes.

Add [Authorize] keyword on top of controller to mandate authorized request. If the request to a particular method needs to be unauthorized, use [AllowAnonymous] keyword on that method(not the whole controller).
Add authentication middleware to startup class
----------------------
DATABASE (Code First):
----------------------
To access entity framework tools(terminal):
-dotnet ef -h

To create classes to scaffold the database for the first time: dotnet ef migrations add InitialCreate (Creates Migrations folder)
To undo the operation: dotnet ef migrations remove

This creates a model in database(Tables) from the models in DbSet in DataContext.cs

To add/update tbales in database based on the migrations done: dotnet ef database update

Retrive data from database:
1. Inject the DataContext in the controller needed by making constructor and adding the context.

-----------------------
Use async code for scalability:
1. It returns a Task<>
2. Queries use await keyword 
3. ToList() becomes ToListAsync()

Storing password in database: Hashing(SHA512)+ Salting(Add random Key)
------------------------
ANGULAR:
------------------------
For Angular install: cmd: npm install -g @ngular/cli 
Check version by: ng --version
Create new project outside of the API: ng new ProjectName-SPA (Angular doesnt allow . in project name so use - instead)

Start angular application: ng serve

Extensions needed: Angular snippets, Angular files, Angular language service, Angular2-switcher, Auto rename tag, Bracket pair colorizer, Debugger for chrome, Material icon thereme, Path intellisense, Prettier- code formatter, Tslint

To create a new component: Right click app folder(inside src forlder) and select Generate Component. Name of the component should not contain extension and is all lowercase.

Need to import HttpClientModule in package.json to import data from API to SPA.

Shortcuts to navigate: alt+o=html page, alt+u=ts page 

npm install rxjs@6.0.0 --save for rxjs error


npm install bootstrap @fortawesome/fontawesome-free for installing font aswome icons and bootstrap

If we install bootstrap and font aswome, we also need to add it in angular.json file. To do so, go to styles.css and inject the bootstrap.min.css and fontawesome.min.css







