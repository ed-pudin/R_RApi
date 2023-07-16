using R_RApi.DataAccessLayer.Mapper;
using R_RApi.DataAccessLayer.Models;
using R_RApi.DomainLayer.Services;

namespace R_RApi.ApplicationLayer.Servicios
{
    public class UserDAO : IUserDAO
    {
        public string signUp(user u)
        {
            UserMappper mapper = new UserMappper();
            return mapper.signup(u);

        }

        public string login(string email, string pass)
        {
            UserMappper mapper = new UserMappper();
            return mapper.login(email, pass);
        }
        public string editClient(user u)
        {
            UserMappper mapper = new UserMappper();
            return mapper.editClient(u);
        }
        public string deleteClient(user u)
        {
            UserMappper mapper = new UserMappper();
            return mapper.deleteClient(u);
        }


    }
}
