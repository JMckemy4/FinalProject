using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using FinalProject;

namespace YourNamespace.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExternalApiController : ControllerBase
    {
        private readonly IHttpClientFactory _clientFactory;

        public ExternalApiController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            // Define the URL of the external API
            var apiUrl = "https://weed-strain1.p.rapidapi.com/";

            try
            {
                // Create an HTTP client
                var client = _clientFactory.CreateClient();

                // Set the base URL
                client.BaseAddress = new Uri(apiUrl);

                // Add headers
                client.DefaultRequestHeaders.Add("X-RapidAPI-Key", "a173573224msh0d90e570559d8dfp11d60bjsn0d424b4bbfcb");
                client.DefaultRequestHeaders.Add("X-RapidAPI-Host", "weed-strain1.p.rapidapi.com");

                // Make the GET request
                var response = await client.GetAsync("");

                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsStringAsync();
                    return Ok(data);
                }
                else
                {
                    // Handle errors
                    return StatusCode((int)response.StatusCode, "Error fetching data from the external API.");
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during the request
                return StatusCode(500, "An error occurred: " + ex.Message);
            }
        }
    }
}