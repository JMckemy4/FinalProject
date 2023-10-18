using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

public class ApiCall
{
    public static async Task<string?> GetApiResponse()
    {
        using (var client = new HttpClient())
        {
            client.DefaultRequestHeaders.Add("X-RapidAPI-Key", "a173573224msh0d90e570559d8dfp11d60bjsn0d424b4bbfcb");
            client.DefaultRequestHeaders.Add("X-RapidAPI-Host", "weed-strain1.p.rapidapi.com");

            var requestUri = "https://weed-strain1.p.rapidapi.com/";

            try
            {
                using (var response = await client.GetAsync(requestUri))
                {
                    response.EnsureSuccessStatusCode();
                    return await response.Content.ReadAsStringAsync();
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"HTTP Request Error: {ex.Message}");
                return null;
            }
        }
    }
}

