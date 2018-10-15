# HW-4
This HW assignment was similar to HW-2, but this time we created the web application using Razor pages, while we used MVC in HW-2. 
In this assignment, we created a web page where we can list the name of movies, we can edit, delete, search, and add movie names. In addition, from another tutorial we created a public and private schedule. 

# Razor over traditional MVC
There are few benefits on using Razor over traditional MVC. The first one is Razor pages are more organized, In Razor pages, most of files we need are under one directory or folder(Pages), where in MVC there are lot's of directories like, controllers, model, views, shared, etc.. So Razor pages is less time consuming when it comes to find specific files, you don't have to run throught folder to folder and have no idea where is the file. With Razor Pages, each page is self-contained with its view and code organized together. This follows the Single Responsibility Principle. In other hand with MVC, there are some huge controller classes that are filled with many different actions, which is confusing and it get's bigger as things get added.  

# Everything old is new again. 
we could make an argument that Razor Pages are the perfect solution to anything that is essentially a web page within your app. It would draw a clear line in the sand that any HTML pages in your app are true pages. Currently, an MVC action could return an HTML view JSON a file, or anything. Using Pages would force a separation between how you load the page and what services the AJAX callbacks.

