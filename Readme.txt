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
Automapper- Map models to DTOs
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

If a model is updated then change to database can be made by-> DataContext File -> Add new dbset for new model(if created)

run, dotnet ef migrations add 'MigrationName', to update the database (MigrationName shouldnt be in quotes)

Revert database from last update: dotnet ef database update 'PrevMigrationName'-> where PrevMigrationName is the last migration name after which you want to delete migrations

dotnet ef database drop for deleteing the database.

Use seeding method to add data to database in bunch. Only used in development mode and need to comment out after first use. If not done so, it will keep recalling the database population everytime the code restarts.

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

Just like dotnet has repositories to handle all the heavylifting logic code, angular has services for the same(in app folder, create _services and generate all services inside that and then add the service in the providers array in app.modules.ts)

ALERTIFY JS: npm install alertifyjs --save --> Also add to angular.json-> scripts array and styles.css -> make a service to have all alertify methods and inject it where needed

https://github.com/auth0/angular2-jwt for angular JWT handler-> npm install @auth0/angular-jwt

Install ngx-bootstrap for more reactive angular frontend(works like JQuery)-> npm install ngx-bootstrap@3.0.1 --save

Add themes using bootswatch: npm install bootswatch@4.1.1

routes.ts for adding routes: ordering of routes is important because if wildcard is on the top then it will by default match and give wrong redirection.

type a-router and complete the router link in html tags

in app.component.html, remove app-home tag and add router-outlet tag instead

route-guards: to prevent navigating from url: in cmd for app-spa: cd src/app/_guard -> ng g guard auth --spec=false

import authguard in providers in app.module.ts 

add resolver in app folder to resolve the variables that are nullable

Import the resolver to app.module.ts in the providers and routes.ts in the path





