using R_RApi.DataAccessLayer.Mapper;
using R_RApi.DomainLayer.Services;

namespace R_RApi.ApplicationLayer.Servicios
{
    public class ProductDAO : IProductDAO
    {
        public string addProduct(string name, string description, int quantity, float price, bool isActive)
        {
            throw new NotImplementedException();
        }

        public string getProduct(string id, string name, string description, int quantity, float price, bool isActive)
        {
            ProductMapper productMapper = new ProductMapper();
            return productMapper.GetProduct(id, name, description, quantity, price, isActive);
        }

        //public string GetProductDAO()
        //{
        //    ProductMapper productMapper = new ProductMapper();
        //    return productMapper.GetProduct(id, name, description, quantity, price, isActive);
        //}
    }
}
