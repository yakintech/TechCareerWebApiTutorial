using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using TechCareerWebApiTutorial.Models.Auth;
using TechCareerWebApiTutorial.Models.DTO;
using TechCareerWebApiTutorial.Models.ORM;

namespace TechCareerWebApiTutorial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        TechCareerDbContext db;

        public AuthController()
        {
            db = new TechCareerDbContext();
        }

        [HttpPost]
        public IActionResult Login(LoginRequestModel model)
        {
            var user = db.WebUsers.FirstOrDefault(q => q.EMail == model.Email && q.Password == model.Password);

            if( user != null)
            {
                TechCareerTokenHandler tokenHandler = new TechCareerTokenHandler();
                var token = tokenHandler.CreateAccessToken(user.EMail);

                return Ok(token);
            }
            else
            {
                return BadRequest("Kullanıcı adı veya şifre hatalı");
            }
        }



    }
}
