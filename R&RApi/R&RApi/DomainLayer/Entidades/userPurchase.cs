namespace R_RApi.DomainLayer.Entidades
{
    public class userPurchases
    {
        public string? id {  get; set; }
        public string userFK { get; set; }
        public string purchaseFK { get; set; }
        public DateTime datePurchase { get; set;}
    }
}
