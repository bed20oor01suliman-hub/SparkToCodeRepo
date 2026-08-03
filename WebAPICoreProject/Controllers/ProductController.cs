using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPICoreProject.Models;

namespace WebAPICoreProject.Controllers
{
    [ApiController]
    [Route("Product")]
    public class ProductController : ControllerBase
    {
        //was done in EFCore
        //ProjectContext context = new ProjectContext();
        private ProjectContext context;

        public ProductController(ProjectContext _context)
        {
            context = _context;
        }
        //Request URL http://localhost:5001/Product/AddProduct
        //Request method => Post
        // Request Body => {"ProductName":"iphone","ProductDescription":"electronic device",
        //                  "ProductPrice":"320.5","CategoryID":2}
        //Sen reques ==>> call function
        [HttpPost("AddProduct")]
        public IActionResult AddProduct(Product p)
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
            //response
            return Ok(p.ProductID);
        }

        //Request URL http://localhost:5001/Product/RemoveProduct?id=3
        //Request method => Delete
        // Request Body => empty
        //Sen reques ==>> call function

        [HttpDelete("RemoveProduct")]
        public IActionResult RemoveProduct(int id)
        { 
            Product p = context.Products.FirstOrDefault(p => p.ProductID == id );
            if (p == null)
            {
                return NotFound("Product not found");
            }

            else
            {
                context.Products.Remove(p);
                context.SaveChanges();
                return Ok("Removed successfuly");
            }

        }

        [HttpPatch("UpdateProductPrice")] //for singleupdate
        public IActionResult UpdateProductPrice(int id,double newPrice)
        {
            Product p = context.Products.FirstOrDefault(p => p.ProductID == id);
            p.ProductPrice = newPrice;
            context.SaveChanges();
            return Ok();
        }

        [HttpPatch("UpdateProductName")] //for singleupdate
        public IActionResult UpdateProductName(int id, string newName)
        {
            Product p = context.Products.FirstOrDefault(p => p.ProductID == id);
            p.ProductName = newName;
            context.SaveChanges();
            return Ok();
        }

        [HttpPut("UpdateProduct")] //for full update
        //update full product
        public IActionResult UpdateProduct(int id, Product newProduct)
        {
            Product p = context.Products.FirstOrDefault(p => p.ProductID == id);
            p.ProductName = newProduct.ProductName;
            p.ProductPrice = newProduct.ProductPrice;
            p.ProductDescription = newProduct.ProductDescription;
            context.SaveChanges();
            return Ok();
        }

        [HttpGet("GetProduct")]
        //singl product
        public IActionResult GetProduct(int id)
        {
            Product p = context.Products.FirstOrDefault(p => p.ProductID == id);
            return Ok(p);
        }

        [HttpGet("GetAllProducts")]
        //all products
        public IActionResult GetAllProducts()
        {
            List<Product> products = context.Products.ToList();
            return Ok(products);
        }

        [HttpGet("GetByName")]
        public IActionResult GetByName(string name)
        {
            List<Product> products = context.Products.Where(p => p.ProductName.Contains(name)).ToList();
            return Ok(products);
        }

    }
}
