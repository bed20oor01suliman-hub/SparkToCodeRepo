using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace WebAPICoreProject.Models
{
    public class Category
    {
        [Key]
        [JsonIgnore]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        
        //[1] Category : [M] Products
        public List<Product> products { get; set; } //M



    }
}
