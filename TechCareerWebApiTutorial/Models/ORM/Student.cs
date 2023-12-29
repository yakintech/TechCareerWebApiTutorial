namespace TechCareerWebApiTutorial.Models.ORM
{
    public class Student : BaseModel
    {
        public string Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }

        //many to many relationship courses
        public List<Course> Courses { get; set; }
    }
}
