using Microsoft.AspNetCore.Mvc;
using R_RApi.ApplicationLayer.Servicios;
using R_RApi.DataAccessLayer.Models;
using R_RApi.DomainLayer.Services;

namespace R_RApi.ApplicationLayer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet("GetProduct/{id}")]
        public string getProduct(string id)
        {
            ProductDAO productsDAO = new ProductDAO();
            return new string(productsDAO.getProduct(id));
        }
        [HttpGet("GetProducts")]
        public IActionResult getProducts()
        {
            ProductDAO productsDAO = new ProductDAO();
            ResponseApi productsResponse = productsDAO.getProducts();
            return Ok(productsResponse);
        }

        [HttpPost("AddProduct")]
        public string addProducts(product p)
        {
            ProductDAO productsDAO = new ProductDAO();
            return new string(productsDAO.addProduct(p));
        }
    }
}
