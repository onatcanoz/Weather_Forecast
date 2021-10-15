using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Weather_Forecast.Models;

namespace Weather_Forecast.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ContentResult GetData(string cityName)
        {
            if (cityName == "Istanbul")
            {
                using StreamReader streamReader = new StreamReader("JsonData//Istanbul.json");
                string cityWeatherDetailJson = streamReader.ReadToEnd();
                return Content(cityWeatherDetailJson);
            }
            else if(cityName == "Ankara")
            {
                using StreamReader streamReader = new StreamReader("JsonData//Ankara.json");
                string cityWeatherDetailJson = streamReader.ReadToEnd();
                return Content(cityWeatherDetailJson);
            }
            else if (cityName == "Izmir")
            {
                using StreamReader streamReader = new StreamReader("JsonData//Izmir.json");
                string cityWeatherDetailJson = streamReader.ReadToEnd();
                return Content(cityWeatherDetailJson);
            }
            else if (cityName == "Madrid")
            {
                using StreamReader streamReader = new StreamReader("JsonData//Madrid.json");
                string cityWeatherDetailJson = streamReader.ReadToEnd();
                return Content(cityWeatherDetailJson);
            }
            else if(cityName == "Paris")
            {
                using StreamReader streamReader = new StreamReader("JsonData//Paris.json");
                string cityWeatherDetailJson = streamReader.ReadToEnd();
                return Content(cityWeatherDetailJson);
            }

            return Content("");
        }


        //CORS hatası aldığım için api'ye çıkamadım.

        //public async Task<IActionResult> GetData(string cityName)
        //{
        //    var cityWeatherDetailModel = new List<CityWeatherDetailModel>();
        //    var cityApiUrl = "https://www.metaweather.com/api/location/search/?query=" + cityName;
        //    using (var httpClient = new HttpClient())
        //    {
        //        using (var response = await httpClient.GetAsync(cityApiUrl))
        //        {
        //           var cityModel=JsonConvert.DeserializeObject<CityModel>(await response.Content.ReadAsStringAsync());

        //            var cityDetailApiUrl = "https://www.metaweather.com/api/location/" + cityModel?.woeid + "/2021/10/9/";

        //            using (var secondResponse = await httpClient.GetAsync(cityDetailApiUrl))
        //            {
        //                cityWeatherDetailModel = JsonConvert.DeserializeObject<List<CityWeatherDetailModel>>(await response.Content.ReadAsStringAsync());



        //            }

        //        }
        //    }


        //    return Content(cityWeatherDetailModel.ToString());
        //}

    }
}
