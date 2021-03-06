# Gummi Bear Kingdom

#### _App created for Epicodus Independent Project, ASP.NET - Week One. Practice using ASP.NET MVC. August 4th, 2017_

#### By **Alyssa Moody**

## Description

_An app that manages the products of Gummi Bear Kingdom._

## Program Specifications

| Description  | Input Example | Output Example |
| ------------- | ------------- | ------------- |
| The program allows users to view a landing page.  | Home  | "Welcome"  |
| The program allows users to view all products.  | /Products  | All Products  |
| The program allows users to add a new product to the database.  | /Products/Add  | --  |
| The program allows users to edit products in the database.  | /Products/Edit  | --  |
| The program allows users to delete products from the database.  | /Products/Delete  | --  |

_This website's style loosely mimics the styling of [Emporium Pies](http://emporiumpies.com/)._

## Setup/Installation Requirements

**Requirements**

If you do not have Visual Studio 2017, download [HERE](https://www.visualstudio.com/thank-you-downloading-visual-studio/?sku=Community&rel=15).

If you do not have SSMS, download [HERE](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms).

**Cloning From GitHub:** Download or clone project repository onto desktop from GitHub.

Open the project in Visual Studio.

**Migrations**
1. In Solution Explorer, right-click the project and choose 'Open in File Explorer' from the context menu.
2. Enter "cmd" in the address bar and press Enter.
3. Enter the following command in the command window:
  - dotnet ef database update
4. Open gummi_scripts.sql in SSMS and execute (this will add sample data).
5. Back in VS, click IIS Express at the top of the window. Project should open in a new window in your default browser.

## Screenshots
![alt text](https://user-images.githubusercontent.com/9857432/29033296-6ea27ab2-7b49-11e7-9909-3a93c20ac87d.png)
![alt text](https://user-images.githubusercontent.com/9857432/29033295-6e930622-7b49-11e7-89cc-eabc1a28e46d.png)
![alt text](https://user-images.githubusercontent.com/9857432/29033303-72817b74-7b49-11e7-8799-8e9b98ef013d.png)
![alt text](https://user-images.githubusercontent.com/9857432/29033307-73e5a0f8-7b49-11e7-973f-1050c53e84af.png)

## Known Bugs

_No known bugs._

## Support and contact details

_If you run into any issues or have questions, ideas or concerns, please contact Alyssa Moody at alyssanicholemoody@gmail.com_

## Technologies Used

**Languages:** HTML, CSS, C#, ASP.NET

**IDE:** Visual Studio 2017

**Database Management:** MySQL (SSMS)

### License

*MIT license Agreement*

Copyright (c) 2017 **_Alyssa Moody_*
