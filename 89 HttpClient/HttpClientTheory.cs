/* HTTPClient 

In C#, HttpClient is a powerful class for sending HTTP requests and receiving HTTP responses. It’s part of the System.Net.Http namespace and is commonly used to interact with web services and APIs. Designed for efficiency, HttpClient is intended to handle HTTP communication asynchronously, making it perfect for modern applications that need to remain responsive while waiting on external resources.

-> What is HttpClient?

HttpClient is a high-level class that provides a flexible and feature-rich way to make HTTP requests. It supports methods for sending HTTP verbs like GET, POST, PUT, and DELETE, and it works seamlessly with async and await, allowing for non-blocking requests that keep applications responsive.

-> Key Characteristics of HttpClient

Reusability: HttpClient is designed to be reused across multiple requests. Each new instance can create underlying system resources (like sockets), which can be a problem in high-load scenarios if you create a new HttpClient instance each time. Instead, you should reuse a single instance.

Asynchronous Support: HttpClient provides asynchronous methods that return Task objects, allowing you to call APIs without blocking the main thread.

Flexible Configuration: You can set headers, configure authentication, manage timeouts, and control cookies using HttpClient.

-> Basic Usage of HttpClient

Here's a simple example of how to use HttpClient to make a GET request to fetch data from a URL.

-> Example of a GET Request

----------------------------------------------------------------------------
using System;
using System.Net.Http;
using System.Threading.Tasks;

public class ApiClient
{
    private static readonly HttpClient client = new HttpClient();

    public async Task GetDataAsync()
    {
        try
        {
            string url = "https://jsonplaceholder.typicode.com/posts/1";

            // Make an asynchronous GET request
            HttpResponseMessage response = await client.GetAsync(url);

            // Ensure the request was successful
            response.EnsureSuccessStatusCode();

            // Read the response content as a string
            string responseData = await response.Content.ReadAsStringAsync();

            Console.WriteLine(responseData);
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine($"Request error: {e.Message}");
        }
    }
}
----------------------------------------------------------------------------

In this example:

client.GetAsync(url) sends a GET request to the specified URL.

response.EnsureSuccessStatusCode() throws an exception if the HTTP status code is an error code (not 2xx).

response.Content.ReadAsStringAsync() reads the response content as a string.

-> Example of a POST Request

In a POST request, you send data to the server, usually in JSON format. Here’s how to do it with HttpClient:

----------------------------------------------------------------------------
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class ApiClient
{
    private static readonly HttpClient client = new HttpClient();

    public async Task PostDataAsync()
    {
        try
        {
            string url = "https://jsonplaceholder.typicode.com/posts";
            string jsonData = "{\"title\":\"foo\",\"body\":\"bar\",\"userId\":1}";

            // Create content with JSON data
            HttpContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            // Make a POST request
            HttpResponseMessage response = await client.PostAsync(url, content);

            response.EnsureSuccessStatusCode();

            string responseData = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseData);
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine($"Request error: {e.Message}");
        }
    }
}
----------------------------------------------------------------------------

Here:

StringContent wraps the JSON data so it can be sent with the POST request.

client.PostAsync(url, content) sends the POST request with the JSON data.

You can handle the response the same way as in the GET example.

-> Setting Headers

You can add custom headers to your HTTP requests using the DefaultRequestHeaders property. This is useful for authentication tokens, content types, and other configurat

----------------------------------------------------------------------------
client.DefaultRequestHeaders.Add("Authorization", "Bearer your_token");
client.DefaultRequestHeaders.Add("User-Agent", "MyApp/1.0");
----------------------------------------------------------------------------

-> Handling Timeouts

The default timeout for HttpClient is quite long. You can set a custom timeout to better handle potential delays in the network or server response.

----------------------------------------------------------------------------
client.Timeout = TimeSpan.FromSeconds(30);
----------------------------------------------------------------------------

-> Reusing HttpClient

Creating multiple HttpClient instances can lead to socket exhaustion, as each instance establishes new connections to the server. The recommended practice is to reuse a single HttpClient instance throughout the application:

Or, in an ASP.NET Core application, you can register HttpClient in the dependency injection container so that the framework manages its lifecycle.

-> Common Patterns with HttpClient

Using Task.WhenAll() for Parallel Requests
You can make multiple requests concurrently using Task.WhenAll():

----------------------------------------------------------------------------
public async Task FetchMultipleDataAsync()
{
    var url1 = "https://jsonplaceholder.typicode.com/posts/1";
    var url2 = "https://jsonplaceholder.typicode.com/posts/2";

    Task<string> task1 = client.GetStringAsync(url1);
    Task<string> task2 = client.GetStringAsync(url2);

    // Run both tasks concurrently
    await Task.WhenAll(task1, task2);

    Console.WriteLine($"Data from URL 1: {task1.Result}");
    Console.WriteLine($"Data from URL 2: {task2.Result}");
}
----------------------------------------------------------------------------

-> Error Handling with HttpClient

Because HTTP requests can fail, wrap your calls in try-catch blocks to handle exceptions like HttpRequestException:

----------------------------------------------------------------------------
try
{
    HttpResponseMessage response = await client.GetAsync("https://example.com");
    response.EnsureSuccessStatusCode();
}
catch (HttpRequestException ex)
{
    Console.WriteLine($"Request failed: {ex.Message}");
}
----------------------------------------------------------------------------

-> Advanced Configuration with HttpClientHandler

To configure advanced options like cookies, SSL certificates, or proxies, you can use HttpClientHandler:

----------------------------------------------------------------------------
var handler = new HttpClientHandler
{
    UseCookies = true,
    CookieContainer = new CookieContainer(),
    Proxy = new WebProxy("http://myproxy:8080")
};

var client = new HttpClient(handler);
----------------------------------------------------------------------------

-> Summary

HttpClient is a versatile class that simplifies HTTP communication, especially when working with APIs. By following best practices such as reusing instances, handling timeouts, and configuring headers, you can ensure efficient and reliable network requests in your C# applications.

*/