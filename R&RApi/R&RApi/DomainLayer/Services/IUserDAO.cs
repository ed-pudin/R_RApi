using R_RApi.DataAccessLayer.Models;

namespace R_RApi.DomainLayer.Services
{
    public interface IUserDAO
    {
        public string signUp(user u);
        public string editClient(user u);
        public string login(string email, string pass);
    }
}
