using Microsoft.AspNetCore.Mvc;

namespace TechCareerWebApiTutorial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        [HttpGet]
        public string[] Get()
        {
            string[] cities = new string[] { "Istanbul", "Ankara", "Izmir", "Bursa", "Antalya" };
            return cities;
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            string[] cities = new string[] { "Istanbul", "Ankara", "Izmir", "Bursa", "Antalya" };

            // Check if the id is valid
            if (id < 0 || id >= cities.Length)
            {
                return "Invalid ID";
            }
            else
            {
                return cities[id];
            }
        }   


    }
}
