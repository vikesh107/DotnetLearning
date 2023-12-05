namespace AsyncExample
{
    internal class Program
    {
        static async void Main()
        {
            await GetDataAsync();
        }

        static async Task GetDataAsync()
        {
            // Create an instance of HttpClient (assumes you have using System.Net.Http;)
            using (HttpClient httpClient = new HttpClient())
            {
                Console.WriteLine("Start of GetDataAsync method");

                // Simulate an asynchronous HTTP request
                HttpResponseMessage response = await httpClient.GetAsync("https://jsonplaceholder.typicode.com/todos/1");

                // Ensure the HTTP request was successful before proceeding
                response.EnsureSuccessStatusCode();

                // Read and display the content of the response
                string content = await response.Content.ReadAsStringAsync();
                Console.WriteLine("Data received: " + content);

                Console.WriteLine("End of GetDataAsync method");
            }
        }
    }
}