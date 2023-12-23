namespace TechCareerWebApiTutorial.Models
{
    public class WebUser
    {

        public WebUser(string email, int id)
        {
              this.EMail = email;
              this.Id = id;
        }

        public int Id { get; set; }
        public string EMail { get; set; } = string.Empty;

        public Address Address { get; set; }
    }
}
