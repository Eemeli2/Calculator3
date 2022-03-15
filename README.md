# Calculator3
Calculator3 is a placeholder name for a repository with a plethora of diffrent functions, including functions for mobile apps and databases.
Read below for more information about each aspect. The project can be used freely as a template for similiar projects.



## 1. Practice1




## 2. AnimalKingdom




## 3. Omaprojekti1




## 4. Bullet solution

Bullet solution is a collection of services and clients such as BulletLibrary, BulletWebApplication and Reloading.Services.
Each component plays a part in making the application work as intended.

The purpose of BulletLibrary and other clients/services is to contain information and elements for the app that components might need to function, such as diameter and mass.
_Reloading (inserting information to a database) for example, only works if it gets what it needs from the BulletLibrary and other services._

What has been implemented: Web page to display and insert bullet data to a database.

### Changelog /// Current objectives:
1. Figure out what is causing the Blazor web application to not function properly.
the cause: Something added/or not properly implemented with Caliber and its components is causing the web application to crash.
~~Edit EntityCaliberService.cs and possibly EntityDiameterService.cs~~
Caliber information had not been migrated to the database and this caused the issues.
Solution: after adding a new service, migrate them to the database on the package manager console with the commands "Add-migration" <migration name> and "Update-database"

2.  Use a Razor component to implement diameter so code is re-usable on other pages. Do this for every component. Start by moving c# and html code from fetchdata.razor to their own respective components like DiameterComponent (already done) to reduce re-use of code.
  
  All components done. Code is now re-usable in FetchData and CaliberPage.
  
  UI issue, pages not displaying elements correctly.
  - Fixed UI. Component location now dependant on page itself rather than the component.
  ~~Make a child component for displaying selected Elements.~~
  
  Fetchdata.razor cleaned up and is now a page with reusable components
  - Change name of Fetchdata.razor to something more suitable
  - Also update UI for CaliberPage

3. Implement proper, clean nice looking UI for FetchData and CaliberPage.
  





