using Microsoft.AspNetCore.Mvc;
using WebApi1.Models;

namespace WebApi1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CitiesController:ControllerBase
    {
        List<CityDto> citiesData;
        public CitiesController()
        {
            citiesData = new List<CityDto>();
            citiesData.Add(new CityDto { Id = 1, Name = "Mercedes", Description = "S600" });
            citiesData.Add(new CityDto { Id = 2, Name = "Volvo", Description = "245" });
            
        }


        [HttpGet]
        public JsonResult GetCites()
        {
            return new JsonResult(CitiesDataStor.Current.Cities);
        }

    }
}
