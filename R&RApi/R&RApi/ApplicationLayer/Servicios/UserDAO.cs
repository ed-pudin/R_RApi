using R_RApi.DataAccessLayer.Mapper;
using R_RApi.DataAccessLayer.Models;
using R_RApi.DataAccessLayer.Response;
using R_RApi.DomainLayer.Services;

namespace R_RApi.ApplicationLayer.Servicios
{
    public class UserDAO : IUserDAO
    {
        public ResponseApi signUp(user u)
        {
            UserMappper mapper = new UserMappper();
            return mapper.signup(u);
        }

        public ResponseApi login(string email, string pass)
        {
            UserMappper mapper = new UserMappper();
            return mapper.login(email, pass);
        }
        public ResponseApi editClient(user u)
        {
            UserMappper mapper = new UserMappper();
            return mapper.editClient(u);
        }
        public ResponseApi deleteClient(string id)
        {
            UserMappper mapper = new UserMappper();
            return mapper.deleteClient(id);
        }


    }
}
