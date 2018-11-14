# Order-Processing
Order Process Program
--The program is implemented in C# using the standard Repository pattern.

--The main objective of the pattern is to loosely couple database access from the
application.

--The project OrderProcess.Repositories.common contains all the basic interface that
should be implemented for each repository. That means if we are using SQL Server we
have different implementation of Repository than if we use MySQL.

--The project OrderProcess.Repositories.SQLServer contains example of how the
repository can be implemented for SQL Server using Entity framework code Model first
approach.

--The entry point to the application is Unit Test project itself. Due to time limitations, I was
not able to create the full UI to intake data for orders. So, I created mockup test data in
Unit test project and use that to call the ProcessOrder method in the Business layer.

--The methods ChargePayment have not been implemented as it was not mentioned in
the requirement. But the method would call to some third party API and get the result as
true or false.

--Please go to the OrderProcessTest project and run all tests. Each test is designed to run
for the whole ordering process rather than individual functionalities.
