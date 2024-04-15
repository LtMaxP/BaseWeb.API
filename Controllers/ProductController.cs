using BaseWeb.API.Services;
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
        public IActionResult Products()
        {
            var result = ProductService.GetAllProduct();
            return null;
        }
    }
}
