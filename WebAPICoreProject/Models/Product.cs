using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace WebAPICoreProject.Models
{
    public class Product
    {
        [Key]
        [JsonIgnore]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public double ProductPrice { get; set; }

        [ForeignKey("_category")]
        public int CategoryID { get; set; }

        public Category _category { get; set; } //1


    }
}
