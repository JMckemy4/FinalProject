using FinalProject;
using FinalProject.Models;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

public class ApiCall
{
    public static List<ViewStrains> GetApiResponse()
    {
        using (var client = new HttpClient())
        {
            client.DefaultRequestHeaders.Add("X-RapidAPI-Key", "a173573224msh0d90e570559d8dfp11d60bjsn0d424b4bbfcb");
            client.DefaultRequestHeaders.Add("X-RapidAPI-Host", "weed-strain1.p.rapidapi.com");

            var requestUri = "https://weed-strain1.p.rapidapi.com/";


            var response = client.GetStringAsync(requestUri).Result;

            JArray formattedResponse = JArray.Parse(response);
            List<ViewStrains> strains = new List<ViewStrains>();



            for (int i = 0; i <= 50; i++)
            {
                string strainName = formattedResponse[i]["strain"].ToString();
                string thc = formattedResponse[i]["thc"].ToString();
                string cbd = formattedResponse[i]["cbd"].ToString();
                string cbg = formattedResponse[i]["cbg"].ToString();
                string Straintype = formattedResponse[i]["strainType"].ToString();
                string climate = formattedResponse[i]["climate"].ToString();
                string difficulty = formattedResponse[i]["difficulty"].ToString();
                string fungalResistance = formattedResponse[i]["fungalResistance"].ToString();
                string Goodeffects = formattedResponse[i]["goodEffects"].ToString();
                string Sideeffects = formattedResponse[i]["sideEffects"].ToString();
                string Types = formattedResponse[i]["types"]?.ToString();
                string? Images = formattedResponse[i]["images"]?.ToString();

                ViewStrains strain = new ViewStrains
                {
                    Strain = strainName,
                    THC = thc,
                    CBD = cbd,
                    CBG = cbg,
                    StrainType = Straintype,
                    Climate = climate,
                    Difficulty = difficulty,
                    FungalResistance = fungalResistance,
                    GoodEffects = Goodeffects,
                    SideEffects = Sideeffects,
                    Image = Images,
                    Type = Types,
                };

                strains.Add(strain);
            }

            return strains;
        }
    }
}


