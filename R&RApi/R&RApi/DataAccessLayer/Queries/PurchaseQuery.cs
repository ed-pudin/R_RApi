namespace R_RApi.DataAccessLayer.Queries
{
    public class PurchaseQuery
    {
        public PurchaseQuery() { }

        public string addPurchase()
        {
            return "INSERT INTO purchase (service, subtotalService,subtotalProducts, payment, change, total)" +
                    " VALUES (@service, @subtotalService, @subtotalProducts,@payment, @change, @total)";
        }
    }
}
