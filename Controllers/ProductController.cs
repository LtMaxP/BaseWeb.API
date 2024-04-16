using BaseWeb.API.Services.Implementations;
using BaseWeb.Core.Dtos;
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

        [HttpGet("ProductsGetAll")]
        public List<ProductDto> ProductsGetAll()
        {
            var prodServ = new ProductService();
            var result = prodServ.GetAllProduct();
            return null;
        }
    }
}
