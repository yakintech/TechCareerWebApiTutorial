namespace TechCareerWebApiTutorial.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal UnitPrice { get; set; }
        public Category Category { get; set; }
    }
}
