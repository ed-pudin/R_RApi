namespace R_RApi.DataAccessLayer.Models
{
    public class userBooking
    {
        public string? id { get; set; }
        public string userFK { get; set; }
        public string bookingFK { get; set; }
        public DateTime datePurchase { get; set; }
    }
}
