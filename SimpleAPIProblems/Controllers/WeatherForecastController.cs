using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SimpleAPIProblems.Models;
using System.Net.Http.Headers;

namespace SimpleAPIProblems.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        public int GetDiscountedPrice(int barcode)
        {
            string baseURL = "https://jsonmock.hackerrank.com/api/inventory";
            string urlParams = "?barcode=" + barcode;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(baseURL);

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync(urlParams).Result;
            if (response.IsSuccessStatusCode)
            {
                var dataObjects = response.Content.ReadAsStringAsync().Result;
                var result = JsonConvert.DeserializeObject<DataObject>(dataObjects)?.data;
                if (result == null || result.Count == 0)
                {
                    return -1;
                }
                else
                {
                    var product = result[0];
                    int discountedPrice = product.price - ((product.discount / 100) * product.price);
                    return discountedPrice;
                }
            }
            else
            {
                return -1;
            }
        }
    }
}