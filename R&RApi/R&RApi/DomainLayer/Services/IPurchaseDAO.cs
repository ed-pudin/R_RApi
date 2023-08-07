using R_RApi.DataAccessLayer.Models;
using R_RApi.DataAccessLayer.Response;

namespace R_RApi.DomainLayer.Services
{
    public interface IPurchaseDAO
    {
        public ResponseApi addPurchase( purchase pu );

    }
}
