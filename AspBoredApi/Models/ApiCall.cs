using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;


namespace AspBoredApi.Models
{
    public class ApiCall
    {
        public ActivityProperties GetActivity()
        {


            var client = new HttpClient();
            var BoredApiUrl = "http://www.boredapi.com/api/activity/";
            var BoredApiResponse = client.GetStringAsync(BoredApiUrl).Result;
            var boredObject = JObject.Parse(BoredApiResponse);

            return new ActivityProperties()
            {
                Activity = boredObject["activity"].ToString(),
                Type = boredObject["type"].ToString(),

            };
            //var BoredApiResult = JObject.Parse(BoredApiResponse).GetValue("activity").ToString();
            //return (BoredApiResult);
        }
    }
}







