namespace TechCareerWebApiTutorial.Models.Auth
{
    public class TokenModel
    {
        public string accessToken { get; set; }
        public DateTime ExpireDate { get; set; }
    }
}
