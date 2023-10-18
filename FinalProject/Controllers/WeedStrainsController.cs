using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace FinalProject
{
    public class WeedStrainsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public WeedStrainsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> YourAction()
        {
            var client1 = _httpClientFactory.CreateClient("RapidAPI1");
            var client2 = _httpClientFactory.CreateClient("RapidAPI2");
            var client3 = _httpClientFactory.CreateClient("RapidAPI3");
            var client4 = _httpClientFactory.CreateClient("RapidAPI4");
            var client5 = _httpClientFactory.CreateClient("RapidAPI5");

            
            var request5 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://weed-strain1.p.rapidapi.com/")
            };

            //using (var response5 = await client5.SendAsync(request5))
            //{
            //    response5.EnsureSuccessStatusCode();
            //    var body5 = await response5.Content.ReadAsStringAsync();
            //    Console.WriteLine(body5);
            //}

            var response5 = await client5.SendAsync(request5);
            
                response5.EnsureSuccessStatusCode();
                var body5 = await response5.Content.ReadAsStringAsync();
                Console.WriteLine(body5);
            

            return View(body5);
        }
    }
}