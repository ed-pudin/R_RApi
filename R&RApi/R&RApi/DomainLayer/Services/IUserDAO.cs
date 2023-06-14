using R_RApi.DomainLayer.Entidades;

namespace R_RApi.DomainLayer.Services
{
    public interface IUserDAO
    {
        public string agregarUsuario(user u);
        public string login(string email, string pass);
    }
}
