--- June 02, 2019

OrionAutoCRUD is a C# libraby which helps you to create CRUD operations using EntityFramework and your database. 
The current version is tested with SQL Server and EntityFramework 6 Database first model but 
can also work with the code first model and other databases.


The project contains a file named CRUDClass.cs. This class is the kernel class.
It's a generic custom class that takes your model class in parameter and makes the following methods available 
to your class.

1- Insert (Use this method to insert your entry into the database)
2- Update (use this method to update an entry from the database)
3- Delete (Use this method to delete an entry from the database)
4- Get (Use those methods to get all entries or a specific entry from the database)

How to use ?

CRUDClass is a static class so no need to instanciate it.
The first operation to do is to call the Initialize method.
The Initialize method takes either your connectionString or your EntityFramework Database Context.

After that, call the CRUD methods..

Example :

CRUDClass<Employee>.Initialize(ctx);  // ctx is my database context variable

var allEmployees = CRUDClass<Employee>.Get();  // To get all the Employees from the Employee table





------------------------------------------------------------------------------------------------------
To test the code in the Program.cs file, you should : 

1- Create a database in SQL Server using the script. file
2- Open the App.config file of the project and edit the connectionString according to your database configuration.
3- Enjoy.



Thank you for your feedbacks !!!


------------------------------------------------------------------------------------------------------











