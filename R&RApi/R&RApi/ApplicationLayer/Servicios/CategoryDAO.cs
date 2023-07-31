using R_RApi.DataAccessLayer.Mapper;
using R_RApi.DataAccessLayer.Models;
using R_RApi.DataAccessLayer.Response;
using R_RApi.DomainLayer.Services;

namespace R_RApi.ApplicationLayer.Servicios
{
    public class CategoryDAO : ICategoryDAO
    {
        public ResponseApi addCategory(category c)
        {
            CategoryMapper categoryMapper = new CategoryMapper();
            return categoryMapper.addCategory(c);
        }

        public ResponseApi deleteCategory(string id)
        {
            throw new NotImplementedException();
        }

        public ResponseApi editCategory(string id, category p)
        {
            CategoryMapper categoryMapper = new CategoryMapper();
            return categoryMapper.editCategory(id, p);
        }

        public ResponseApi getCategories()
        {
            throw new NotImplementedException();
        }
    }
}
