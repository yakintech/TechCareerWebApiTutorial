using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TechCareerWebApiTutorial.Models.ORM;

namespace TechCareerWebApiTutorial.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BlogController : ControllerBase
    {
        private readonly TechCareerDbContext _context;

        public BlogController()
        {
            _context = new TechCareerDbContext();
        }

        [HttpGet]
        public IActionResult Get()
        {
            //databasedeki blogları getir
            var blogs = _context.Blogs.Include(x => x.BlogCategory).ToList();
            return Ok(blogs);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            //disaridan gelen id ile blogu bul
            //find metodu primary keye göre arama yapar
            //var blog = _context.Blogs.Find(id);

            //firstordefault metodu icerisine yazdığımız sorguya göre arama yapar
            var blog = _context.Blogs.FirstOrDefault(x => x.Id == id);

            //blog yoksa 404 döndür
            if (blog == null)
            {
                return NotFound();
            }

            return Ok(blog);
        }

        [HttpPost]
        public IActionResult Create(Blog blog)
        {
            
            _context.Blogs.Add(blog);
            _context.SaveChanges();

            return StatusCode(201, blog);
        }

        //delete
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            //disaridan gelen id ile blogu bul
            var blog = _context.Blogs.FirstOrDefault(x => x.Id == id);

            //blog yoksa 404 döndür
            if (blog == null)
            {
                return NotFound();
            }

            _context.Blogs.Remove(blog);
            _context.SaveChanges();

            return Ok(blog);
        }
                
    }
}
