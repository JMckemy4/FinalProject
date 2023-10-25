using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq; // Add this using statement
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace FinalProject
{
    public class WeedStrainsController : Controller
    {
        public IActionResult Index()
        {
            var strains = ApiCall.GetApiResponse();
            return View(strains);
        }
    }
}
        