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
        public string signUp(user u)
        {
            u.rol = "client";
            UserDAO userDAO = new UserDAO();
            return new string(userDAO.signUp(u));
        }

    }
}
