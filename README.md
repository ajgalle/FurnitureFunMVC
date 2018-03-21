FurnitureFun is a demo of a Furniture Store eCommerce site written in Visual Studio 2017.

If you would like to see a live version, please see: 
http://furniturefun.gear.host/

TECHNOLOGIES USED:

It uses C#/ASP.net made into the Model-View-Controller (MVC) architecture. It has persistance capabilities and CRUD operations powered
by Entity Framework 6 and a live MS SQL Server. It validates form inputs both on the server and through unobtrusive javascript client-
side validation.  The database was generated using a Code First design and populates itself through seed data. 

I enhanced the user interfaces to be mobile responsive using CSS3, Bootstrap and jQuery. It features custom CSS, shadow and hover effects,
a slide carousel, and much more.  

OVERVIEW: 

The site can be viewed either as a shopper or as the store's order fulfillment specialist. 

A customer can:

Read details of the available pieces by clicking on them from the gallery view on the index page. 
They may also place orders for furniture, creating a new record in the database that has a one-to-many relationship set.  The input
they write into the order form is validated both on the client and server side.  Data annotations are used and HTML helper methods 
generate validation errors for the viewer to see.  A TempData message verifies the entry of each order. 

An administrator can:

Click a button to indicate an order has been fulfilled to take it out the queue of pending orders by deleting it from the database. 
In a real world application, I would prefer to instead mark the entry with "IsDeleted" set to true, and then code it so it wouldn't 
show, but the host I'm using has very little space allowed in the free tier. 

Edit or update an order in case a customer made a mistake and needs it corrected prior to fulfillment. 

The orders are generated dynamically and are viewable by the administrator as soon as they are entered by the customer. 

Please feel free to let me know what you think.  










