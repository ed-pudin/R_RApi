using Microsoft.AspNetCore.Mvc;
using R_RApi.ApplicationLayer.Servicios;

using R_RApi.DataAccessLayer.Models;

namespace R_RApi.ApplicationLayer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {
        [HttpPut("Edit/{id}")]
        public IActionResult editClient(string id, user data)
        {
            data.id = id;
            //Obtener rol del token
            data.rol = "client";
            UserDAO userDAO = new UserDAO();
            return Ok(userDAO.editClient(data));
        }
        [HttpPut("Delete/{id}")]
        public IActionResult deleteClient(string id, user data)
        {
            data.id = id;
            data.isActive = false;
            //Obtener rol del token
            data.rol = "client";
            UserDAO userDAO = new UserDAO();
            return Ok(userDAO.deleteClient(data));
        }
    }
}
