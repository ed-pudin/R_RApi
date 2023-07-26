using Microsoft.AspNetCore.Mvc;
using R_RApi.ApplicationLayer.Servicios;
using R_RApi.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace R_RApi.ApplicationLayer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SignupController : ControllerBase
    {
        [HttpPost(Name = "Registro")]
        public IActionResult signUp(user u)
        {
            //Obtener rol del token
            u.rol = "client";
            UserDAO userDAO = new UserDAO();
            return Ok(userDAO.signUp(u));
        }

    }
}
