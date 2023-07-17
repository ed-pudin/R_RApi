using R_RApi.DataAccessLayer.Models;

namespace R_RApi.DomainLayer.Services
{
    public interface IProductDAO
    {
        public string addProduct(product p);

        public string getProduct(string id);

    }
}
