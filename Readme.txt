Description:
This solution is made up of two projects: MyService and MySite. MyService is an AspNetCore API service. MySite is 
an AspNetCore Website, implemented using Angular v8.

You will need to implement a *Users* API within MyService, and then wire up those APIs in the Angular site 
within the MySite project. 

Note that we've integrated MyService with swagger so you can test your APIs without the need for an external
test tool (such as Postman), just by running the project

MySite has a couple existing components you can use as a reference:
* CounterComponent - Simple UI the increments a counter by clicking a button
* FetchDataComponent - Displays a table of weather data that is pulled using an HttpClient call.

You are allowed to use your favorite search engine to look up various syntax and examples if needed.

When you are ready to test, just hit F5 to run both projects. Do NOT use the command line.

For your reference, the backend host URI is https://localhost:44378.


Actions:

1. Implement the API. Open MyService\Controllers\UserController.cs and review the TODO comments.  You need 
to implement three API Actions for the specified UserStore methods. Make sure to test that your three APIs 
work before moving on.

2. Display the list of Users. Work with the UsersComponent found in MySite\ClientApp\src\app\users\. 
The model for an User is defined in users.component.ts. You are responsible for developing the UI and TS 
code for making the HTTP call to the backend to get the list of users.

3. Add the ability to create a new User in the UI and wire it up to the backend API. Make sure to refresh the 
User list after you add a new user.