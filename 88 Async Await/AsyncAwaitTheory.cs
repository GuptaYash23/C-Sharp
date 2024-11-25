/* Synchronous vs Asynchronous Programming

In C#, synchronous and asynchronous programming are two fundamental approaches for handling tasks, especially tasks that involve waiting for external resources, like reading files, accessing databases, or calling APIs. Understanding the differences between them is essential for writing efficient and responsive applications.

1. Synchronous Programming

In synchronous programming, tasks are executed sequentially. Each line of code waits for the previous line to complete before moving on to the next one. This means if a method makes a request to an external resource (e.g., a database or an API), the entire program will wait until the request is complete before continuing.

-> Example of Synchronous Code

------------------------------------------------------------------------
public void ProcessData()
{
    string data = GetData();
    Console.WriteLine(data);
}

public string GetData()
{
    // Simulate a delay
    System.Threading.Thread.Sleep(3000);  // Simulates waiting for 3 seconds
    return "Hello, World!";
}
------------------------------------------------------------------------

In this example:

ProcessData() calls GetData().

GetData() waits for 3 seconds before returning a value.

While waiting, the main thread is blocked, which can cause the application to be unresponsive.

-> Pros of Synchronous Programming:

Simpler to read and understand, as tasks happen in a strict sequence.
Useful when tasks are small, quick, and non-blocking.

-> Cons of Synchronous Programming:

Inefficient for time-consuming tasks, as it blocks the main thread, leading to unresponsiveness.
In applications with a user interface (UI), synchronous tasks can make the app freeze while waiting.

2. Asynchronous Programming

In asynchronous programming, tasks can run in the background, allowing the application to continue doing other work while waiting for the task to complete. This is particularly useful for I/O-bound operations, like file handling, web requests, or database access. With asynchronous programming, the app remains responsive, as it doesn’t block the main thread.

C# uses the async and await keywords to handle asynchronous programming.

-> Example of Asynchronous Code

------------------------------------------------------------------------
using System.Net.Http;
using System.Threading.Tasks;

public async Task ProcessDataAsync()
{
    string data = await GetDataAsync();
    Console.WriteLine(data);
}

public async Task<string> GetDataAsync()
{
    HttpClient client = new HttpClient();
    // Asynchronously get data from a URL
    string data = await client.GetStringAsync("https://example.com");
    return data;
}
------------------------------------------------------------------------

In this example:

ProcessDataAsync() calls GetDataAsync() and uses await to pause without blocking the main thread until GetDataAsync() completes.

The application remains responsive while GetDataAsync() waits for the external HTTP request to finish.

Once the task completes, execution resumes, and the data is printed to the console.

-> Pros of Asynchronous Programming:

Non-blocking: The main thread remains responsive, making it ideal for applications with a UI or multiple tasks.
Efficient for I/O-bound operations that involve waiting for external resources.

-> Cons of Asynchronous Programming:

Can be more complex, requiring familiarity with async and await syntax and handling potential exceptions.
Not all tasks benefit from being asynchronous, especially short tasks with minimal waiting time.

-> Key Concepts in Asynchronous Programming

Async: Adding async to a method’s signature tells the compiler that the method may contain await calls, allowing it to run asynchronously.

Await: The await keyword pauses the method execution until the awaited task completes, without blocking the thread. The method resumes execution after the awaited task finishes.

Task and Task<T>: In asynchronous programming, methods typically return a Task (for void methods) or Task<T> (for methods returning a value). This allows the calling code to wait for the task to complete.

-> When to Use Synchronous vs. Asynchronous

Use synchronous programming when tasks are short and do not involve waiting, as the overhead of setting up asynchronous tasks may not be justified.

Use asynchronous programming for tasks that involve I/O operations, web requests, file reading, or database queries. Asynchronous programming keeps applications responsive and can handle multiple tasks more efficiently.

-> Example of Using Both Approaches

You can mix synchronous and asynchronous code in a way that fits your application’s needs:

------------------------------------------------------------------------
public void ProcessData()
{
    Console.WriteLine("Starting sync task...");
    Task.Run(async () => await ProcessDataAsync()).Wait();
    Console.WriteLine("Sync task completed.");
}

public async Task ProcessDataAsync()
{
    // Simulate an async task
    await Task.Delay(2000);
    Console.WriteLine("Async task completed.");
}
------------------------------------------------------------------------

In this example:

ProcessData() runs synchronously but uses Task.Run to start an asynchronous operation.

This can be useful when you need to bridge the gap between synchronous and asynchronous operations.

-> Summary

Synchronous: Executes tasks one by one, ideal for quick operations but blocks the main thread.

Asynchronous: Enables tasks to run in the background, ideal for I/O operations and resource-intensive tasks.

In C#, asynchronous programming with async and await is powerful for writing responsive, efficient applications, especially when dealing with external resources or UI-based programs.

*/

/* Async Await

In C#, async and await are keywords used to write asynchronous code, allowing you to perform time-consuming tasks (such as file I/O, database access, and web requests) without blocking the main thread. This approach makes applications more responsive, especially in GUI applications, as it allows the UI to remain responsive while waiting for background tasks to complete.

-> Basics of Async and Await

async: When you mark a method with the async keyword, it tells the compiler that the method contains asynchronous operations.

await: Within an async method, you use the await keyword to indicate a point where the method should wait for a Task to complete, without blocking the calling thread.

-> How Async and Await Work

When you call an asynchronous method, it usually returns a Task or Task<T> (for methods returning a result). When the method reaches an await keyword, it pauses the method’s execution until the awaited task is complete. Meanwhile, the control is returned to the caller, allowing other code to run on the calling thread.

-> Example: Basic Async and Await Usage

------------------------------------------------------------------------
public async Task DownloadDataAsync()
{
    HttpClient client = new HttpClient();

    // The await keyword here pauses this method until the download is complete
    string data = await client.GetStringAsync("https://example.com");

    Console.WriteLine(data);
}
------------------------------------------------------------------------

In this example, DownloadDataAsync calls client.GetStringAsync(), which is an asynchronous operation. The await keyword tells the method to pause here without blocking the thread. Once the download is complete, the method resumes and prints the data.

-> Why Use Async and Await?

Non-blocking Execution: Asynchronous code does not block the main thread, which is particularly useful in UI applications to keep the interface responsive.

Concurrency: Async/await allows you to run multiple tasks concurrently. For example, you can initiate multiple web requests and await them simultaneously.

Code Simplicity: Async/await is more readable and maintainable than traditional callback-based asynchronous programming.

-> Returning Values with Async

When a method returns a value, you use Task<T> as the return type. For example:

------------------------------------------------------------------------
public async Task<string> FetchDataAsync()
{
    HttpClient client = new HttpClient();
    string data = await client.GetStringAsync("https://example.com");
    return data;
}
------------------------------------------------------------------------

Here, FetchDataAsync returns a Task<string>, allowing the caller to await the result and get the string once the task is complete.

-> Using Async in the Caller

When calling an async method, you can also use await to get the result:

------------------------------------------------------------------------
public async Task ProcessDataAsync()
{
    string data = await FetchDataAsync();
    Console.WriteLine(data);
}
------------------------------------------------------------------------

In this example, ProcessDataAsync calls FetchDataAsync and awaits its result. This pattern of chaining async methods helps maintain asynchronous behavior throughout the call chain.

-> Handling Exceptions in Async Methods

Exceptions within async methods are automatically captured and stored in the Task object. You can handle them with a try-catch block:

------------------------------------------------------------------------
public async Task ProcessDataAsync()
{
    try
    {
        string data = await FetchDataAsync();
        Console.WriteLine(data);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}
------------------------------------------------------------------------

-> Common Patterns with Async and Await

Using async void for Event Handlers: Only use async void for event handlers, as it cannot be awaited or tracked.

Avoiding .Wait() and .Result: These can cause deadlocks; instead, use await.

Parallel Async Calls: Use Task.WhenAll() to run multiple asynchronous tasks in parallel.

For example:

------------------------------------------------------------------------
public async Task ProcessMultipleRequestsAsync()
{
    Task<string> task1 = FetchDataAsync("https://example.com/1");
    Task<string> task2 = FetchDataAsync("https://example.com/2");

    await Task.WhenAll(task1, task2);

    Console.WriteLine($"Data 1: {task1.Result}");
    Console.WriteLine($"Data 2: {task2.Result}");
}
------------------------------------------------------------------------

-> Summary

Async and await simplify asynchronous programming by allowing asynchronous code to look and behave similarly to synchronous code. The await keyword suspends the method’s execution until the awaited task completes, enabling non-blocking code execution and improving application responsiveness.

*/

/* Task Class

The Task class will always represent a single operation and that operation will be executed asynchronously on a thread pool thread rather than synchronously on the main thread of the application

*/

/* Code Example

1. Synchronous code

The below code will run synchronously

------------------------------------------------------------------------------------
using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Task1()
        {
            Console.WriteLine("Task 1 Starting ...");
            Thread.Sleep(4000);
            Console.WriteLine("Task 1 Completed");
        }

        public static void Task2()
        {
            Console.WriteLine("Task 2 Starting ...");
            Thread.Sleep(3000);
            Console.WriteLine("Task 2 Completed");
        }

        public static void Task3()
        {
            Console.WriteLine("Task 3 Starting ...");
            Thread.Sleep(1000);
            Console.WriteLine("Task 3 Completed");
        }

        public static void Task4()
        {
            Console.WriteLine("Task 4 Starting ...");
            Thread.Sleep(6000);
            Console.WriteLine("Task 4 Completed");
        }
        public static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
        }
    }
}
------------------------------------------------------------------------------------

Output:

------------------------------------------------------------------------------------
Task 1 Starting ...
Task 1 Completed
Task 2 Starting ...
Task 2 Completed
Task 3 Starting ...
Task 3 Completed
Task 4 Starting ...
Task 4 Completed
------------------------------------------------------------------------------------

2. Asynchronous code 

The below code will run asynchronously and the Task having less delay will be completed first.

------------------------------------------------------------------------------------
using System;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Program
    {
        public static async Task Task1()
        {
            Console.WriteLine("Task 1 Starting ...");
            await Task.Delay(4000); // Non-blocking delay
            Console.WriteLine("Task 1 Completed");
        }

        public static async Task Task2()
        {
            Console.WriteLine("Task 2 Starting ...");
            await Task.Delay(3000); // Non-blocking delay
            Console.WriteLine("Task 2 Completed");
        }

        public static async Task Task3()
        {
            Console.WriteLine("Task 3 Starting ...");
            await Task.Delay(1000); // Non-blocking delay
            Console.WriteLine("Task 3 Completed");
        }

        public static async Task Task4()
        {
            Console.WriteLine("Task 4 Starting ...");
            await Task.Delay(6000); // Non-blocking delay
            Console.WriteLine("Task 4 Completed");
        }

        public static async Task Main(string[] args)
        {
            // Start all tasks and wait for them to complete
            await Task.WhenAll(Task1(), Task2(), Task3(), Task4());
        }
    }
}
------------------------------------------------------------------------------------

Output:

------------------------------------------------------------------------------------
Task 1 Starting ...
Task 2 Starting ...
Task 3 Starting ...
Task 4 Starting ...
Task 3 Completed
Task 2 Completed
Task 1 Completed
Task 4 Completed
------------------------------------------------------------------------------------
*/
