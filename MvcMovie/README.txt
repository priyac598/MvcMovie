2024-05-09
Lehya Priya Chintalapudi
Web app created VS and .Net
SSL cert SH-1

1530
Tested and modified the app.completed part 1 by successfully creating a program of HelloWorld and runned the program 
using Web browser Chrome.

1600
Started part 2 and added a controller.Completed the two controller methods and runned in the web browser 
Microsoft Edge.Changed the address to localhost:5001/HelloWorld/Welcome and the output displayed successfully.

2024-05-16 

1420
Started part 3.Added a new folder in the views folder and named as HelloWorld.Selected a Razor view-Empty file 
and saved as Index.cshtml and clicked to add it.

1430
UnCommented the return view in the HelloWorldControllers file and executed Index.cshtml and successfully 
runned in the web browser Microsoft Edge.

2024-05-23

0220
Completed working on part 3.Changed views,layout pages and changed the title, footer and  menu link in the layout
file.Completed the passing data from the controller view.

02:50
Started part-4,Added a data model class, NuGet Packages and added New Scaffold Item. Runned the commands Add-Migration InitialCreate and
Update-Database in the Package Manager Console.

20240530184031_InitialCreate file has been created in the migration folder.


03:15
Scaffolding added a connection string to the appsettings.json file.Successfully executed the files 
and could be able to edit the list.
https://localhost:7138/Movies
Created the Movie list of 5 and submitted.The list list we have created is shown in the Movie app.
If we wanted to see for the particular Movie id from the list used the below link to display the record 
of the first movie from the list created.
https://localhost:7138/movies/details?id=1

03:30
Examined the Migrations/{timestamp}_InitialCreate.cs migration file
Opened the Controllers/MoviesController.cs file and examined the constructor.
Examined  the generated Details method in the Controllers/MoviesController.cs file.
Examined the contents of the Views/Movies/Details.cshtml file.

0405
Started working on part 5.Opened SQL Server Express LocalDB and examined the local database from the 
view menu>Database>System databases>dbo.movie>View Data
The available data has been displayed successfully.
Added a new class in the Models Folder and named as SeedData.Replaced the code from the SeedData.cs 
and added code in the program.cs file.
Successfully runed the file and I can see the app list available with the data created.

2024-05-30

1210
Part 5
Worked with SQL data base editor and examined the values given is updated as given in the browser.Verified the 
gap between the Release and date in the browser and corrected it in the program.cs file.

Part 6
Examined the controller methods and views.Checked the Edit URL link and verified with unknown data so that it gives
the error message that means it is controlling the app.
https://localhost:7019/Movies/Edit

Part 7
Started part 7 and added search option.
Veirfied the URL https://localhost:7019/Movies?searchString=Ghost 
and it displayes the Ghost movies which are listed.
Added filter option to the Movies list and tried checking it, sucessfully executed.
Veirfied the URL https://localhost:7019/Movies

2024-06-06

01:15pm
Part 8
Started and Completed part 8 successfully.
Added a new field of Rating property to the Movies Model.
Updated the Rating filed in the create.cshtml and updated SeedData with Rating field added.

Part 9:
Started and Completed part 8 successfully.
Added validations to the movie model.

02:00 pm
Part 10:
Completed part 10 successfully and
Examined all the details in the Edit.cshtml, Create.cshtml,Moviecontroller.cs, and Program.cs.


02:40 pm
Signed up to the git hub and created a repository.
Cloned the repository and Pushed the code into it.
https://github.com/priyac598/MvcMovie/
Checked with the team members whether the link is working fine from there end.


