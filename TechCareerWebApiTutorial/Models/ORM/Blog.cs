using System.ComponentModel.DataAnnotations;

namespace TechCareerWebApiTutorial.Models.ORM
{
    public class Blog : BaseModel
    {

        [MaxLength(50)]
        public string Title { get; set; }
        public string? Description { get; set; }
    }
}
