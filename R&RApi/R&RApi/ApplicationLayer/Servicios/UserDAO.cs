using R_RApi.DataAccessLayer.Mapper;
using R_RApi.DataAccessLayer.Models;
using R_RApi.DomainLayer.Services;

namespace R_RApi.ApplicationLayer.Servicios
{
    public class UserDAO : IUserDAO
    {
        public string agregarUsuario(user u)
        {
            throw new NotImplementedException();
        }

        public string login(string email, string pass)
        {
            UserMappper mapper = new UserMappper();
            return mapper.login(email, pass);
        }
    }
}
