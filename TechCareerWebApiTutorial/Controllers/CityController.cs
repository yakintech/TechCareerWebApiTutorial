using Microsoft.AspNetCore.Mvc;
using TechCareerWebApiTutorial.Models;

namespace TechCareerWebApiTutorial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        [HttpGet]
        public string[] Get()
        {
            //instance of WebUser class
            //var webUser = new WebUser("cagatay@mail.com");    


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
