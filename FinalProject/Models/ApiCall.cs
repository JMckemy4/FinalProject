using FinalProject;
using FinalProject.Models;
using Newtonsoft.Json.Linq;


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

                //formattedResponse[0]["strain"];

                for (int i = 0; i <= 10; i++)
                {
                    string strainName = formattedResponse[i]["strain"].ToString();
                    string thc = formattedResponse[i]["thc"].ToString();

                ViewStrains strain = new ViewStrains
                {
                    Strain = strainName,
                    THC = thc
                   
                   
                
                
                };
               
                    strains.Add(strain);
                }

                return strains;
                



            }
        }
    }


