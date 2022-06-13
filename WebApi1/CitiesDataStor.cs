using WebApi1.Models;

namespace WebApi1
{
    public class CitiesDataStor
    {
        public List<CityDto> Cities { get; set; }
        public static CitiesDataStor Current { get; }=new CitiesDataStor();
        public CitiesDataStor()
        {
            Cities = new List<CityDto>()
            {
                   new CityDto() { Id = 1, Name = "Damascuse" ,Description=""},
                   new CityDto(){Id=2,Name="Allepo",Description=""}


            };
        }
    }
}
