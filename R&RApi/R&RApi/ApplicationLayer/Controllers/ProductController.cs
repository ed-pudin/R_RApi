using Microsoft.AspNetCore.Mvc;
using R_RApi.ApplicationLayer.Servicios;
using R_RApi.DataAccessLayer.Models;
using R_RApi.DataAccessLayer.Response;

namespace R_RApi.ApplicationLayer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet("GetProduct/{id}")]
        public IActionResult getProduct(string id)
        {
            ProductDAO productsDAO = new ProductDAO();
            ResponseApi productsResponse = productsDAO.getProduct(id);
            return Ok(productsResponse);
        }
        [HttpGet("GetProducts")]
        public IActionResult getProducts()
        {
            ProductDAO productsDAO = new ProductDAO();
            ResponseApi productsResponse = productsDAO.getProducts();
            return Ok(productsResponse);
        }

        [HttpPost("AddProduct")]
        public IActionResult addProducts(product p)
        {
            ProductDAO productsDAO = new ProductDAO();
            return Ok(productsDAO.addProduct(p));
        }
    }
}
