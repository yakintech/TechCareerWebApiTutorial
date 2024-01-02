using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace TechCareerWebApiTutorial.Models.Auth
{
    public class TechCareerTokenHandler
    {
        public TokenModel CreateAccessToken(string email)
        {

            var claims = new[]
            {
                new Claim(ClaimTypes.Email, email),
            };

            var token = new TokenModel();
            token.ExpireDate = DateTime.Now.AddMinutes(5);

            SymmetricSecurityKey key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"));

            SigningCredentials credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            JwtSecurityToken jwtSecurityToken = new JwtSecurityToken(
                               issuer: "cagatay@mail.com",
                               audience: "cagatay2@mail.com",
                               signingCredentials: credentials,
                               claims: claims,
                               expires: token.ExpireDate
                               );

            // bu class token oluşturmak için kullanılır
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();

            token.accessToken = tokenHandler.WriteToken(jwtSecurityToken);



            return token;
        }
    }
}





