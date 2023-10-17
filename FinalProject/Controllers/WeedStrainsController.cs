using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Http;
using System.Threading.Tasks;

public class WeedStrainController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public async Task<IActionResult> GetWeedStrainData()
    {
        var client = new HttpClient();
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri("https://weed-strain1.p.rapidapi.com/"),
            Headers =
            {
                { "X-RapidAPI-Key", "a173573224msh0d90e570559d8dfp11d60bjsn0d424b4bbfcb" },
                { "X-RapidAPI-Host", "weed-strain1.p.rapidapi.com" },
            },
        };

        using (var response = await client.SendAsync(request))
        {
            if (response.IsSuccessStatusCode)
            {
                var body = await response.Content.ReadAsStringAsync();

                // You can process the response data if needed
                // For now, just return a View
                return View();
            }
            else
            {
                return StatusCode((int)response.StatusCode);
            }
        }
    }
}