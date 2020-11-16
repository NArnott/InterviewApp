Description:
This solution is made up of two projects: MyService and MySite. MyService is an AspNetCore API service. MySite is 
an AspNetCore Website, implemented using Angular v8.

You will need to implement the API layer within MyService, and then wire up those APIs in the Angular site 
within the MySite project. 

Note that we've integrated MyService with swagger so you can test your APIs without the need for an external
test tool (such as Postman), just by running the project

For your reference, the backend host URI is https://localhost:44378.


Actions:

1. Implement the API. Open MyService\Controllers\AddressController.cs and review the TODO comments.  You need 
to implement three API Actions for the specified AddressStore methods. Make sure to test that your three APIs 
work before moving on.

2. Display the list of Addresses. Work with the AddressesComponent found in MySite\ClientApp\src\app\addresses\. 
The model for an Address is defined in addresses.component.ts. You are responsible for developing the UI and TS 
code for making the HTTP call to the backend to get the list of addresses.

3. Add the ability to create a new Address in the UI and wire it up to the backend API.