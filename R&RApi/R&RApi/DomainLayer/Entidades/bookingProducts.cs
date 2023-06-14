namespace R_RApi.DomainLayer.Entidades
{
    public class bookingProducts
    {
        public string? id { get; set; }
        public string bookingFK { get; set; }
        public int productFK { get; set; }
        public int quantity { get; set; }

    }
}
