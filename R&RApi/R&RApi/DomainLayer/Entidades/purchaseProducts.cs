namespace R_RApi.DomainLayer.Entidades
{
    public class purchaseProducts
    {
        public string? id { get; set; }
        public string purchaseFK { get; set;}
        public int productFK { get; set;}
        public int quantity { get; set;}
    }
}
