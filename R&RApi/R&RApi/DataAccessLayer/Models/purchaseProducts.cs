namespace R_RApi.DataAccessLayer.Models
{
    public class purchaseProducts
    {
        public string? id { get; set; }
        public string purchaseFK { get; set; }
        public int productFK { get; set; }
        public int quantity { get; set; }
    }
}
