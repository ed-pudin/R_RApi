using R_RApi.DataAccessLayer.Models;
using R_RApi.DataAccessLayer.Response;

namespace R_RApi.DomainLayer.Services
{
    public interface ICategoryDAO
    {
        public ResponseApi addCategory(category c);
        public ResponseApi editCategory(string id, category p);
        public ResponseApi deleteCategory(string id);
        public ResponseApi getCategories();
    }
}
