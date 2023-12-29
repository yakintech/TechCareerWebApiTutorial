namespace TechCareerWebApiTutorial.Models.ORM
{
    public class Course : BaseModel
    {
        public string Name { get; set; }

        //many to many relationship students
        public List<Student> Students { get; set; }
    }
}
