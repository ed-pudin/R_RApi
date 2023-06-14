using Microsoft.AspNetCore.Mvc;
using R_RApi.ApplicationLayer.Servicios;

namespace R_RApi.ApplicationLayer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        [Route("login")]
        public string login(string email, string pass)
        {

            UserDAO userDAO = new UserDAO();
            return new string(userDAO.login(email, pass));
        }

    }
}
