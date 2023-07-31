using Microsoft.AspNetCore.Mvc;
using R_RApi.ApplicationLayer.Servicios;
using R_RApi.DataAccessLayer.Models;

namespace R_RApi.ApplicationLayer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        [HttpPost("AddCategory")]
        public IActionResult addCategory(category data)
        {
            CategoryDAO catDAO = new CategoryDAO();
            return Ok(catDAO.addCategory(data));
        }
        [HttpGet("GetCategories")]
        public IActionResult getCategories()
        {
            CategoryDAO catDAO = new CategoryDAO();
            return Ok(catDAO.getCategories());
        }
        [HttpPut("EditCategory/{id}")]
        public IActionResult editCategory(string id, category data)
        {
            CategoryDAO catDAO = new CategoryDAO();
            return Ok(catDAO.editCategory(id, data));
        }
    }
}
