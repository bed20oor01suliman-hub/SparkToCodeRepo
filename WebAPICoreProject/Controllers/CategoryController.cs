using WebAPICoreProject.Models;

namespace WebAPICoreProject.Controllers
{
    public class CategoryController
    {
        private ProjectContext context;

        public CategoryController(ProjectContext _context)
        {
            context = _context;
        }
        public void AddCategory(Category c)
        {

            context.Categories.Add(c);
            context.SaveChanges();
        }

        public void RemoveCategory(int id)
        {
            Category c = context.Categories.FirstOrDefault(c => c.CategoryID == id);
            if (c == null)
            {

            }

            else
            {
                context.Categories.Remove(c);
                context.SaveChanges();
            }

        }
        public Category GetCategory(int id)
        {
            Category c = context.Categories.FirstOrDefault(c => c.CategoryID == id);
            return c;
        }
        public List<Category> GetAllCategories()
        {
            List<Category> categories = context.Categories.ToList();
            return categories;
        }

    }
}
