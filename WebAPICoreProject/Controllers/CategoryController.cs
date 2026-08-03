using Microsoft.AspNetCore.Mvc;
using WebAPICoreProject.Models;

namespace WebAPICoreProject.Controllers 
{
    [ApiController]
    [Route("Category")]
    public class CategoryController : ControllerBase
    {
        private ProjectContext context;

        public CategoryController(ProjectContext _context)
        {
            context = _context;
        }
        [HttpPost("AddCategory")]
        public IActionResult AddCategory(Category c)
        {

            context.Categories.Add(c);
            context.SaveChanges();
            return Ok();
        }

        [HttpDelete("RemoveCategory")]
        public IActionResult RemoveCategory(int id)
        {
            Category c = context.Categories.FirstOrDefault(c => c.CategoryID == id);
            if (c == null)
            {
                return NotFound("Category not found");
            }

            else
            {
                context.Categories.Remove(c);
                context.SaveChanges();
                return Ok("Removed successfuly");
            }

        }

        [HttpGet("GetCategory")]
        public IActionResult GetCategory(int id)
        {
            Category c = context.Categories.FirstOrDefault(c => c.CategoryID == id);
            return Ok(c);
        }

        [HttpGet("GetAllCategories")]
        public IActionResult GetAllCategories()
        {
            List<Category> categories = context.Categories.ToList();
            return Ok(categories);
        }

    }
}
