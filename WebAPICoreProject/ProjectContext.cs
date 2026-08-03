using Microsoft.EntityFrameworkCore;
using WebAPICoreProject.Models;

namespace WebAPICoreProject
{
    public class ProjectContext : DbContext 
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        //database Connection
        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options)
        {

        } 
    }
}
