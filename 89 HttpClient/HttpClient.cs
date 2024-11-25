using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class ApiClient
{
    // Reusing a single instance of HttpClient to avoid socket exhaustion.
    private static readonly HttpClient client;

    // Static constructor to initialize HttpClient with default configurations.
    static ApiClient()
    {
        // Using HttpClientHandler to enable advanced configurations
        var handler = new HttpClientHandler
        {
            UseCookies = true,
            CookieContainer = new CookieContainer(),
            Proxy = new WebProxy("http://myproxy:8080"), // Example proxy
            UseProxy = false // Set true to use the proxy specified above
        };

        client = new HttpClient(handler)
        {
            Timeout = TimeSpan.FromSeconds(30) // Set custom timeout
        };

        // Setting common headers that will be included in every request
        client.DefaultRequestHeaders.Add("User-Agent", "MyApp/1.0");
    }

    // Asynchronous GET request to fetch data from an API
    public async Task GetDataAsync()
    {
        try
        {
            string url = "https://jsonplaceholder.typicode.com/posts/1";
            
            // Sending a GET request and awaiting the response asynchronously
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode(); // Throw if status is not 2xx
            
            // Read the response content as a string
            string responseData = await response.Content.ReadAsStringAsync();
            Console.WriteLine("GET Response Data: " + responseData);
        }
        catch (HttpRequestException e)
        {
            // Log error details
            Console.WriteLine($"GET request error: {e.Message}");
        }
    }

    // Asynchronous POST request to send data to an API
    public async Task PostDataAsync()
    {
        try
        {
            string url = "https://jsonplaceholder.typicode.com/posts";
            string jsonData = "{\"title\":\"foo\",\"body\":\"bar\",\"userId\":1}";

            // Preparing JSON content for POST request
            HttpContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            // Sending a POST request with JSON data
            HttpResponseMessage response = await client.PostAsync(url, content);
            response.EnsureSuccessStatusCode(); // Throw if status is not 2xx

            // Read the response content as a string
            string responseData = await response.Content.ReadAsStringAsync();
            Console.WriteLine("POST Response Data: " + responseData);
        }
        catch (HttpRequestException e)
        {
            // Log error details
            Console.WriteLine($"POST request error: {e.Message}");
        }
    }

    // Fetch multiple resources concurrently with Task.WhenAll
    public async Task FetchMultipleDataAsync()
    {
        try
        {
            var url1 = "https://jsonplaceholder.typicode.com/posts/1";
            var url2 = "https://jsonplaceholder.typicode.com/posts/2";

            // Initiating multiple asynchronous GET requests
            Task<string> task1 = client.GetStringAsync(url1);
            Task<string> task2 = client.GetStringAsync(url2);

            // Await all tasks to complete concurrently
            await Task.WhenAll(task1, task2);

            Console.WriteLine("Data from URL 1: " + task1.Result);
            Console.WriteLine("Data from URL 2: " + task2.Result);
        }
        catch (HttpRequestException e)
        {
            // Handle any request errors
            Console.WriteLine($"Fetch multiple data error: {e.Message}");
        }
    }
}

public class Program
{
    public static async Task Main(string[] args)
    {
        ApiClient apiClient = new ApiClient();

        // Calling asynchronous methods and awaiting their completion
        await apiClient.GetDataAsync();            // Perform a GET request
        await apiClient.PostDataAsync();           // Perform a POST request
        await apiClient.FetchMultipleDataAsync();  // Perform multiple GET requests concurrently
    }
}
