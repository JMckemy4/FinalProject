using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using FinalProject;

namespace FinalProject.Models
{
    public class ApiCall
    {
        public AcitivityProperties GetActivity()
        {


            var client = new HttpClient();
            var weedStrainUrl = "https://weed-strain1.p.rapidapi.com/";
            var weedStrainResponse = client.GetStringAsync(weedStrainUrl).Result;
            var weedObject = JObject.Parse(weedStrainResponse);

            return new AcitivityProperties()
            {
                Activity = weedObject["activity"].ToString(),
                Type = weedObject["type"].ToString(),

            };
            
        }
    }
}


