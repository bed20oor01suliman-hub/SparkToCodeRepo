using Microsoft.EntityFrameworkCore;
using WebAPICoreProject.Models;

namespace WebAPICoreProject.Controllers
{

    public class ProductController
    {
        //was done in EFCore
        //ProjectContext context = new ProjectContext();
        private ProjectContext context;

        public ProductController(ProjectContext _context)
        {
            context = _context;
        }
        public void AddProduct(Product p)
        {

            //was done in EFCore
            //Product p = new Product();
            //Console.WriteLine("enter product name");
            //p.ProductName = Console.ReadLine();

            //Console.WriteLine("enter product description");
            //p.ProductDescription = Console.ReadLine();

            //Console.WriteLine("enter product price");
            //p.ProductPrice = double.Parse(Console.ReadLine());

            context.Products.Add(p);
            context.SaveChanges();
        }

        public void RemoveProduct(int id)
        {
            Product p = context.Products.FirstOrDefault(p => p.ProductID == id );
            if (p == null)
            {

            }

            else
            {
                context.Products.Remove(p);
                context.SaveChanges();
            }

        }
        public void UpdateProductPrice(int id,double newPrice)
        {
            Product p = context.Products.FirstOrDefault(p => p.ProductID == id);
            p.ProductPrice = newPrice;
            context.SaveChanges();
        }

        public void UpdateProductName(int id, string newName)
        {
            Product p = context.Products.FirstOrDefault(p => p.ProductID == id);
            p.ProductName = newName;
            context.SaveChanges(); 
        }


        //singl product
        public Product GetProduct(int id)
        {
            Product p = context.Products.FirstOrDefault(p => p.ProductID == id);
            return p;
        }
        //all products
        public List<Product> GetAllProducts()
        {
            List<Product> products = context.Products.ToList();
            return products;
        }
        public List<Product> GetByName(string name)
        {
            List<Product> products = context.Products.Where(p => p.ProductName.Contains(name)).ToList();
            return products;
        }

    }
}
