using System;
using System.Net.Http;
using System.Threading.Tasks;
using FinalProject.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FinalProject.Models
{
    public class ApiCall
    {
        public async Task<ActivityProperties> GetActivity()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("X-RapidAPI-Key", "a173573224msh0d90e570559d8dfp11d60bjsn0d424b4bbfcb");
                    client.DefaultRequestHeaders.Add("X-RapidAPI-Host", "weed-strain1.p.rapidapi.com");

                    var weedStrainUrl = "https://weed-strain1.p.rapidapi.com";

                    var response = await client.GetStringAsync(weedStrainUrl);

                    // Parse the JSON response
                    var weedObject = JObject.Parse(response);

                    // Print the entire JSON response for debugging
                    Console.WriteLine(weedObject.ToString());

                    // Check if the properties exist in the JSON response before accessing them
                    if (weedObject.TryGetValue("activity", out JToken activityToken) && activityToken != null &&
                        weedObject.TryGetValue("type", out JToken typeToken) && typeToken != null)
                    {
                        var activity = (string)activityToken;
                        var type = (string)typeToken;
                        return new ActivityProperties
                        {
                            Activity = activity,
                            Type = type
                        };
                    }
                    else
                    {
                        // Handle the case where the expected properties are not found
                        return new ActivityProperties
                        {
                            Activity = "Activity not available",
                            Type = "Type not available"
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions, e.g., network or JSON parsing errors
                Console.WriteLine($"Error: {ex.Message}");
                return new ActivityProperties
                {
                    Activity = "Error occurred",
                    Type = "Error occurred"
                };
            }
        }
    }
}

