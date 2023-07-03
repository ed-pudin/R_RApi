namespace R_RApi.DomainLayer.Services
{
    public interface IPurchaseDAO
    {
        public string purchase(string service, float subTotalService, float subTotalProducts,
                                float payment, float total );

    }
}
