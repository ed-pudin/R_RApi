namespace R_RApi.DataAccessLayer.Models
{
    public class bookingProducts
    {
        public string? id { get; set; }
        public string bookingFK { get; set; }
        public int productFK { get; set; }
        public int quantity { get; set; }

    }
}
