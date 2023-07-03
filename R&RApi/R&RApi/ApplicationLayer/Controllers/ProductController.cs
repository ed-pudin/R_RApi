using Microsoft.AspNetCore.Mvc;
using R_RApi.ApplicationLayer.Servicios;
using System.Globalization;

namespace R_RApi.ApplicationLayer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet(Name ="getProducts")]
        public string getProducts(string id, string name, string description, int quantity, float price, bool isActive)
        {
            ProductDAO productsDAO = new ProductDAO();
            return new string(productsDAO.getProduct(id, name, description, quantity, price, isActive));
        }

    }
}
