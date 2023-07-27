using Microsoft.AspNetCore.Mvc;
using R_RApi.DataAccessLayer.Models;
using R_RApi.DataAccessLayer.Response;

namespace R_RApi.DomainLayer.Services
{
    public interface IProductDAO
    {
        public ResponseApi addProduct(product p);
        public ResponseApi editProduct(string id, product p);
        public ResponseApi getProduct(string id);
        public ResponseApi getProducts();

    }
}
