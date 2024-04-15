using BaseWeb.API.Entities.Entity;
using BaseWeb.API.Services;
using BaseWeb.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BaseWeb.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : Controller
    {
        public ProductController()
        {
            
        }

        [HttpGet]
        public List<Product> ProductsGetAll()
        {
            var prodServ = new ProductService();
            var result = prodServ.GetAllProduct();
            return null;
        }
    }
}
