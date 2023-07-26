using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using R_RApi.ApplicationLayer.Servicios;
using R_RApi.DataAccessLayer.Models;

namespace R_RApi.ApplicationLayer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        [HttpPost(Name = "login")]
        public IActionResult login(user data)
        {
            string email = data.email;
            string pass = data.password;
            UserDAO userDAO = new UserDAO();
            return  Ok(userDAO.login(email, pass));
        }

    }
}
