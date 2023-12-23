using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TechCareerWebApiTutorial.Models;

namespace TechCareerWebApiTutorial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebUserController : ControllerBase
    {

        static List<WebUser> webusers;

        public WebUserController()
        {
            if (webusers == null)
               webusers = WebUserService.GetWebUsers();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(webusers);
        }

        //get by id
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var webuser = webusers.FirstOrDefault(x => x.Id == id);

            if (webuser == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(webuser);
            }
        }

        //Disarinda bir webuser nesnesi alip, onu listeye ekleyecek
        [HttpPost]
        public IActionResult Post(WebUser webuser)
        {
            webuser.Id = webusers.Count + 1;
            webusers.Add(webuser);

            return StatusCode(StatusCodes.Status201Created, webuser);
        }

        //delete by id
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var webuser = webusers.FirstOrDefault(x => x.Id == id);

            if (webuser == null)
            {
                return NotFound();
            }
            else
            {
                webusers.Remove(webuser);
                return Ok(webuser);
            }
        }
    }
}
