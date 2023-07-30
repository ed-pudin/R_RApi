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
            UserMapper mapper = new UserMapper();
            return mapper.signup(u);
        }

        public ResponseApi login(string email, string pass)
        {
            UserMapper mapper = new UserMapper();
            return mapper.login(email, pass);
        }
        public ResponseApi editClient(user u)
        {
            UserMapper mapper = new UserMapper();
            return mapper.editClient(u);
        }
        public ResponseApi deleteClient(string id)
        {
            UserMapper mapper = new UserMapper();
            return mapper.deleteClient(id);
        }


    }
}
