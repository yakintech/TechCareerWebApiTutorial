using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechCareerWebApiTutorial.Models.ORM
{
    public class Blog : BaseModel
    {

        [MaxLength(50)]
        public string Title { get; set; }
        public string? Description { get; set; }

        public int BlogCategoryId { get; set; }

        [ForeignKey("BlogCategoryId")]
        public BlogCategory BlogCategory { get; set; }

        public int? AuthorId { get; set; }

        [ForeignKey("AuthorId")]
        public Author Author { get; set; }
    }
}
