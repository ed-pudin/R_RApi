using R_RApi.DataAccessLayer.Mapper;
using R_RApi.DataAccessLayer.Models;
using R_RApi.DataAccessLayer.Response;
using R_RApi.DomainLayer.Services;

namespace R_RApi.ApplicationLayer.Servicios
{
    public class PurchaseDAO : IPurchaseDAO
    {
        public ResponseApi addPurchase(purchase pu)
        {
            PurchaseMapper purchaseMapper = new PurchaseMapper();
            return purchaseMapper.addPurchase(pu);
        }
    }
}
