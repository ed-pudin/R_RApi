using Microsoft.AspNetCore.Mvc;
using R_RApi.DataAccessLayer.Mapper;
using R_RApi.DataAccessLayer.Models;
using R_RApi.DataAccessLayer.Response;
using R_RApi.DomainLayer.Services;

namespace R_RApi.ApplicationLayer.Servicios
{
    public class ProductDAO : IProductDAO
    {
        public ResponseApi addProduct(product p)
        {
            ProductMapper productMapper = new ProductMapper();
            return productMapper.addProduct(p);
        }
        public ResponseApi getProduct(string id)
        {
            ProductMapper productMapper = new ProductMapper();
            return productMapper.getProduct(id);
        }
        public ResponseApi getProducts()
        {
            ProductMapper productMapper = new ProductMapper();
            return productMapper.getProducts();
        }
        public ResponseApi editProduct(string id, product p)
        {
            ProductMapper productMapper = new ProductMapper();
            return productMapper.editProduct(id, p);
        }
    }
}
