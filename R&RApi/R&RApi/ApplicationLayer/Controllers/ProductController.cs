using Microsoft.AspNetCore.Mvc;
using R_RApi.ApplicationLayer.Servicios;
using R_RApi.DataAccessLayer.Models;
using System.Globalization;

namespace R_RApi.ApplicationLayer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet("GetProduct/{id}")]
        public string getProducts(string id)
        {
            ProductDAO productsDAO = new ProductDAO();
            return new string(productsDAO.getProduct(id));
        }

        [HttpPost("AddProduct")]
        public string addProducts(product p)
        {
            ProductDAO productsDAO = new ProductDAO();
            return new string(productsDAO.addProduct(p));
        }
    }
}
