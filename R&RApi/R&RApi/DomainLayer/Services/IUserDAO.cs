using R_RApi.DataAccessLayer.Models;
using R_RApi.DataAccessLayer.Response;

namespace R_RApi.DomainLayer.Services
{
    public interface IUserDAO
    {
        public ResponseApi signUp(user u);
        public ResponseApi editClient(user u);
        public ResponseApi deleteClient(string id);
        public ResponseApi login(string email, string pass);
    }
}
