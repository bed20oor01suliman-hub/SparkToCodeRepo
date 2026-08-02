using System.ComponentModel.DataAnnotations;

namespace WebAPICoreProject.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }

    }
}
