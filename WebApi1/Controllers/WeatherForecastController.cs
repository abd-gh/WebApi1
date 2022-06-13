using Microsoft.AspNetCore.Mvc;

namespace WebApi1.Controllers
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

        // First Lecture
        [HttpGet]
        [Route("/getstring")]
        public string Mystring()
        {
            return "your function in our Api :)";
        }



        [HttpPost]
        [Route("/SaveData")]
        public string SaveData(string name)
        {
            System.Diagnostics.Debug.WriteLine(name);
            return name;
        }
        
    }
}


/*CarData = new List<Car>();
            CarData.Add(new Car { Id = 1, Brand = "Mercedes", Model = "S600" });
            CarData.Add(new Car { Id = 2, Brand = "Volvo", Model = "245" });
            CarData.Add(new Car { Id = 3, Brand = "SAAB", Model = "9000" });
            CarData.Add(new Car { Id = 4, Brand = "Audi", Model = "A6" });
            CarData.Add(new Car { Id = 5, Brand = "BMW", Model = "650" });
            CarData.Add(new Car { Id = 6, Brand = "Citroen", Model = "DS5" });
            CarData.Add(new Car { Id = 7, Brand = "Mercedes", Model = "SL500" });
            CarData.Add(new Car { Id = 8, Brand = "BMW", Model = "M5" });
            CarData.Add(new Car { Id = 9, Brand = "Porsche", Model = "S4 Carrera" });
            CarData.Add(new Car { Id = 10, Brand = "Lexus", Model = "400" });
            CarData.Add(new Car { Id = 11, Brand = "Toyota", Model = "Corolla" });
*/