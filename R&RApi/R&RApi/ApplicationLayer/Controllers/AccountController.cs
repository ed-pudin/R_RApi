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
        public string editClient(string id, user data)
        {
            data.id = id;
            UserDAO userDAO = new UserDAO();
            return new string(userDAO.editClient(data));
        }
    }
}
