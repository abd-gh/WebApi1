using Microsoft.AspNetCore.Mvc;

namespace WebApi1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarsController
    {
        List<Car> CarData;
        public CarsController()
        {
            CarData = new List<Car>();
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
        }

        [HttpGet]
        public List<Car> Index()
        {
            return CarData;
        }


        [HttpGet]
        [Route("/getcar/{Id}")]
        public Car GetCar(int Id)
        {
            Car car = CarData.FirstOrDefault(x =>x.Id==Id);
            return car;
        }

        [HttpPost]
        [Route("/addCar")]
        public List<Car> AddCar(int Id, string Brand, string Model)
        {
            Car car = new Car(Id, Brand, Model);
            CarData.Add(car);
            return CarData;
        }

        [HttpPut]
        [Route("/updateCar")]
        public List<Car> UpdateCar(int id, string brand, string model)
        {
            var Car= CarData.FirstOrDefault(x => x.Id == id);
            int CarIndex = CarData.IndexOf(Car);
            CarData[CarIndex].Brand = brand; 
            CarData[CarIndex].Model = model;
            return CarData;

        }

        [HttpDelete]
        [Route("/deletCar")]
        public List<Car> DeleteCar(int id)
        {
            var car = CarData.FirstOrDefault(x => x.Id == id);
            //int CarIndex = CarData.IndexOf(car);
            CarData.Remove(car);

            return CarData;
        }
     
    }
}
