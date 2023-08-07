using Microsoft.AspNetCore.Mvc;
using R_RApi.ApplicationLayer.Servicios;
using R_RApi.DataAccessLayer.Models;

namespace R_RApi.ApplicationLayer.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class PurchaseController : Controller
    {
        [HttpPost("AddPurchase")]
        public IActionResult addPurchase(purchase pu)
        {
            PurchaseDAO purchaseDAO = new PurchaseDAO();
            return Ok(purchaseDAO.addPurchase(pu));
        }
    }
}
