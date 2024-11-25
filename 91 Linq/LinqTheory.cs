/* LINQ

LINQ (Language Integrated Query) is a querying syntax in .NET that allows developers to perform data operations in a consistent way across different data sources like collections, databases, XML, and more. While it may look quite different from SQL at first, LINQ is fundamentally similar to SQL in its purpose: it enables you to retrieve, filter, sort, and aggregate data. Here’s a comparison of LINQ with SQL to illustrate its features and use.

For using LINQ we must use System.Linq namespace.

1. Basic Syntax

SQL is a domain-specific language used primarily for managing and querying relational databases.

LINQ is integrated into .NET languages like C#, providing the ability to write queries directly in the language, which gets translated into expressions that interact with collections or databases.

2. Structure Comparison

Let’s compare the structure of some common operations in SQL and LINQ.

a) Selecting Data

SQL

-------------------------------------------------------------------
SELECT Name, Age FROM Employees WHERE Age > 30;
-------------------------------------------------------------------

LINQ

-------------------------------------------------------------------
var result = from e in Employees
             where e.Age > 30
             select new { e.Name, e.Age };
-------------------------------------------------------------------

- Comparison: The SQL SELECT keyword is analogous to select in LINQ, and FROM in SQL matches the from clause in LINQ.

- Query Composition: SQL separates the data query language from the programming language, while LINQ integrates the query into the language, allowing a more fluent syntax and type-safety within C#.

b) Filtering Data

SQL

-------------------------------------------------------------------
SELECT * FROM Employees WHERE Department = 'Sales';
-------------------------------------------------------------------

LINQ

-------------------------------------------------------------------
var salesEmployees = from e in Employees
                     where e.Department == "Sales"
                     select e;
-------------------------------------------------------------------

- Comparison: SQL uses WHERE for filtering, while LINQ uses where. The filtering conditions work similarly, and LINQ allows expressions with C# operators and methods, making it easier to integrate complex logic.

c) Sorting Data

SQL

-------------------------------------------------------------------
SELECT Name FROM Employees ORDER BY Name DESC;
-------------------------------------------------------------------

LINQ

-------------------------------------------------------------------
var sortedEmployees = from e in Employees
                      orderby e.Name descending
                      select e.Name;
-------------------------------------------------------------------

- Comparison: SQL’s ORDER BY translates to orderby in LINQ. The syntax is quite similar, but LINQ’s ordering is integrated into the C# language.

d) Grouping Data

SQL

-------------------------------------------------------------------
SELECT Department, COUNT(*) FROM Employees GROUP BY Department;
-------------------------------------------------------------------

LINQ

-------------------------------------------------------------------
var departmentGroups = from e in Employees
                       group e by e.Department into g
                       select new { Department = g.Key, Count = g.Count() };
-------------------------------------------------------------------

- Comparison: SQL’s GROUP BY is represented as group ... by in LINQ. The LINQ version uses an anonymous type (new { }) to return grouped results. LINQ groups are treated as collections, which makes further operations on groups flexible and type-safe.

e) Joining Data

SQL

-------------------------------------------------------------------
SELECT Employees.Name, Departments.Name 
FROM Employees
JOIN Departments ON Employees.DepartmentId = Departments.Id;
-------------------------------------------------------------------

LINQ
-------------------------------------------------------------------
var joinResult = from e in Employees
                 join d in Departments on e.DepartmentId equals d.Id
                 select new { EmployeeName = e.Name, DepartmentName = d.Name };
-------------------------------------------------------------------

- Comparison: SQL’s JOIN syntax directly correlates with LINQ’s join ... on ... equals .... LINQ uses equals instead of =, maintaining C# syntax rules, and performs type-checking on both sides of the join.

3. Deferred Execution

- SQL queries execute immediately when called.

- LINQ queries are by default deferred in execution, meaning they are not run until the results are actually needed. This can help optimize performance, as LINQ queries are only evaluated when iterated.

4. Integration with C# Functions

LINQ queries can use functions and expressions from the host language (C#). For example, you can use methods, properties, and local variables within a LINQ query:

-------------------------------------------------------------------
int minAge = 25;
var result = from e in Employees
             where e.Age > minAge
             select e.Name;
-------------------------------------------------------------------

- In SQL, variable integration often requires workarounds or stored procedures, while LINQ makes this integration seamless.

5. Handling Complex Operations

SQL has aggregate functions (such as SUM, AVG, etc.) and can work with complex joins, nested subqueries, and stored procedures for advanced operations. LINQ can perform similar operations but uses C# syntax and built-in functions to execute them.

SQL

-------------------------------------------------------------------
SELECT AVG(Salary) FROM Employees;
-------------------------------------------------------------------

LINQ

-------------------------------------------------------------------
var averageSalary = Employees.Average(e => e.Salary);
-------------------------------------------------------------------

6. Type Safety and IntelliSense

SQL: SQL is a loosely-typed language, meaning that errors are usually detected at runtime.

LINQ: LINQ queries are type-safe and compiled with the C# code. Syntax errors or invalid operations are detected at compile-time, and IntelliSense support in Visual Studio provides guidance and autocomplete suggestions.

7. Execution Context

SQL: SQL is only used for querying databases.

LINQ: LINQ can query various types of data sources: databases (LINQ to SQL, LINQ to Entities), in-memory collections (LINQ to Objects), XML documents (LINQ to XML), and more.

-> Conclusion

While SQL is designed for database querying, LINQ provides a versatile, language-integrated approach for querying data in various sources like query database, XML, collections etc. LINQ’s type safety, compile-time checking, and integration with C# make it an appealing option, especially for developers working in .NET environments.

*/

/* LINQ in C#

LINQ in C# is used to work with data access from data sources such as objects, data sets, SQL Server, and XML etc.

Previously Microsoft introduced SQL query language to interact with only one data source called SQL server database.

But now Microsoft introduced LINQ query language than can be used wide variety of data sources.

LINQ is divided into several categories or you can say that there are different types of LINQ

1. LINQ to SQL

LINQ to SQL is an ORM (Object-Relational Mapping) framework in .NET that allows developers to work with SQL Server databases using .NET objects. LINQ to SQL provides a way to query and manipulate database data directly in C# or VB.NET, without writing raw SQL queries. It translates LINQ (Language Integrated Query) expressions into SQL queries, executes them on the SQL Server, and maps the results to .NET objects.

-> Key Features of LINQ to SQL

1. Object-Relational Mapping (ORM): LINQ to SQL automatically maps database tables to .NET classes and columns to class properties, creating a model layer that represents the database in code.

2. Type-Safety and IntelliSense: LINQ to SQL allows you to work with database data in a type-safe manner, enabling compile-time checks and IntelliSense support in Visual Studio.

3. Query Translation: LINQ queries are translated into SQL queries by LINQ to SQL, allowing developers to write queries in C# that can be executed on SQL Server.

4. CRUD Operations: LINQ to SQL provides built-in support for Create, Read, Update, and Delete operations on the database through the LINQ syntax, which simplifies database interaction.

5. Deferred Execution: LINQ to SQL queries are not executed until the data is iterated (e.g., with foreach) or explicitly requested. This allows more control over when database operations are performed.
Setting Up LINQ to SQL

-> Setting Up LINQ to SQL

1. Define the DataContext: The DataContext class is the main class in LINQ to SQL, which manages the connection to the database and provides access to database tables. Each table is represented by a Table<TEntity> collection in the DataContext.

2. Create Mappings: LINQ to SQL can automatically generate mappings from a database to .NET classes, typically through tools like the Object Relational Designer in Visual Studio. These classes represent the tables in the database, and properties represent columns.

3. Define Relationships: LINQ to SQL can represent relationships between tables (such as one-to-many or many-to-many relationships) by creating associations with attributes like [Association] in the mapped classes.

-> Example: Basic CRUD Operations with LINQ to SQL

Assume we have a database table named Employees with columns EmployeeID, Name, Position, and Salary.

1. Define the Model Class

The following class is an example of how LINQ to SQL maps the Employees table:

-----------------------------------------------------------------------------------
[Table(Name = "Employees")]
public class Employee
{
    [Column(IsPrimaryKey = true)]
    public int EmployeeID { get; set; }
    
    [Column]
    public string Name { get; set; }
    
    [Column]
    public string Position { get; set; }
    
    [Column]
    public decimal Salary { get; set; }
}
-----------------------------------------------------------------------------------

2. Setting Up the DataContext

Define a DataContext class that provides access to the Employees table:

-----------------------------------------------------------------------------------
public class EmployeeDataContext : DataContext
{
    public Table<Employee> Employees;

    public EmployeeDataContext(string connection) : base(connection) { }
}
-----------------------------------------------------------------------------------

3. Performing CRUD Operations

Let's see how LINQ to SQL can perform basic CRUD operations.

-----------------------------------------------------------------------------------
a) Reading Data (SELECT)

using (var context = new EmployeeDataContext("YourConnectionString"))
{
    var employees = from e in context.Employees
                    where e.Position == "Manager"
                    select e;

    foreach (var employee in employees)
    {
        Console.WriteLine($"{employee.Name} - {employee.Position} - {employee.Salary}");
    }
}
-----------------------------------------------------------------------------------

In this example, LINQ to SQL translates the LINQ query into a SQL SELECT statement to retrieve employees with the position of "Manager."

b) Inserting Data (INSERT)

-----------------------------------------------------------------------------------
using (var context = new EmployeeDataContext("YourConnectionString"))
{
    var newEmployee = new Employee
    {
        EmployeeID = 5,
        Name = "Jane Doe",
        Position = "Developer",
        Salary = 70000
    };

    context.Employees.InsertOnSubmit(newEmployee);
    context.SubmitChanges();
}
-----------------------------------------------------------------------------------

InsertOnSubmit queues the new employee for insertion. When SubmitChanges is called, LINQ to SQL generates an INSERT statement and adds the new employee to the database.

c) Updating Data (UPDATE)

-----------------------------------------------------------------------------------
using (var context = new EmployeeDataContext("YourConnectionString"))
{
    var employee = context.Employees.FirstOrDefault(e => e.EmployeeID == 1);
    if (employee != null)
    {
        employee.Salary = 75000;
        context.SubmitChanges();
    }
}
-----------------------------------------------------------------------------------

In this example, LINQ to SQL generates an UPDATE statement to change the salary of the specified employee. The SubmitChanges call executes the update.

d) Deleting Data (DELETE)

-----------------------------------------------------------------------------------
using (var context = new EmployeeDataContext("YourConnectionString"))
{
    var employee = context.Employees.FirstOrDefault(e => e.EmployeeID == 5);
    if (employee != null)
    {
        context.Employees.DeleteOnSubmit(employee);
        context.SubmitChanges();
    }
}
-----------------------------------------------------------------------------------

This code queues the specified employee for deletion and calls SubmitChanges to execute the DELETE statement.

-> Pros and Cons of LINQ to SQL

Pros:

- Simplicity: Queries are written in C#, avoiding the need for raw SQL.

- Type-Safety: Queries are checked at compile-time, reducing runtime errors.

- Productivity: Built-in support for CRUD operations accelerates development.

- Automatic ORM: LINQ to SQL automates mapping tables to classes, so you don’t need to write complex SQL manually.
Cons:

- Limited to SQL Server: LINQ to SQL only supports SQL Server, which restricts cross-database compatibility.
Not Ideal for Complex Queries: For very complex SQL queries or optimized performance, Entity Framework or direct SQL is often more efficient.

- Limited Flexibility: LINQ to SQL lacks some advanced ORM features found in Entity Framework, such as migrations and database-first modeling.

-> When to Use LINQ to SQL

LINQ to SQL is ideal for:

- Small to medium applications that need to connect to SQL Server.

- Situations where rapid development is essential.

- Applications where type safety and compile-time checking are needed.

- Scenarios that don’t require highly complex or optimized queries.

LINQ to SQL is a powerful tool for connecting .NET applications to SQL Server with minimal effort, making it a good choice for straightforward applications with moderate data requirements. However, for more complex applications with advanced requirements or cross-database compatibility, alternatives like Entity Framework are often better suited.

We can also utilize ADO.NET with SQL Server; however, the SQL queries, which are inserted as strings using double quotes, are evaluated at runtime and executed by the SQL Server database engine rather than the C# compiler. It is not considered a best practice to impose additional burdens on the database engine in this manner. Also ADO.NET is not type safe.

Whereas LINQ queries are evaluated at compile time and are not executed by the database engine, they are compiled by the C# compiler due to LINQ's integration within the C# language. LINQ queries are executed and verified by LINQ query engine which is provided in our DotNet framework. Some advantages of using LINQ over ADO.NET is that Compiler time errror checking is available, Intellisense support, Type Safetym, Debugging is possible, Object Oriented Code.

Whenever we implement LINQ to SQL

- Table is converted to Class
- Column is converted to Property
- Row is converted to Object/Instance
- Stored Procedure is converted to Method

To use LINQ to SQL, first we have to convert or map all the relational objects of database into object oriented types.

This process is called ORM (Object Relational Mapping). To perform ORM we need a tool called OR Designer.

*/