2024-05-09 1631
Lehya Priya Chintalapudi
Web application  w/ VS2022 .NET 7
no auth, .....
SSL cert SH-1

1530
Tested and modified the app....
All good

1620
Started Part 2, Added a controller. Have tested two different controller methods and confirmed by running the app in browser, got output.

2024-05-16 1400
Started Part 3, Added a view, created a folder and named HelloWorld under view. Added a New item in Hello World, that is Razor View - Empty, Name box value- Index.cshtml.   

1430
Created a newfolder in views 
name: HelloWorld
added a new item razor view empty, opened the index html file
I tried testing the webpage 
1500
All are running successfully 
urls tested:
https://localhost:7019/
https://localhost:7019/HelloWorld
https://localhost:7019/HelloWorld/Welcome


202405231500
Part 3
https://localhost:7019/Home/Privacy
Successfully got Privacy Policy
https://localhost:7019/HelloWorld/Welcome?name=Vinni&numtimes=4

1540
Part 4
Added a data model class
name=Movie.cs
Add NuGet packages
First i was unable to add new scafflod item then i recognized the issue that was to stop the run and then i could find the add scafflod item and i have added it
as per the instructions
In the Package Manager Console (PMC) i have given the code to add migration and update the database
Then i have run the app and selected the Movie App link
I got the required output
Created a Migration file - 20240530184031_InitialCreate

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

