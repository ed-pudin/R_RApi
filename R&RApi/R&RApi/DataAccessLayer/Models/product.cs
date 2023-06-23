namespace R_RApi.DataAccessLayer.Models
{
    public class product
    {
        public string? id { get; set; }
        public string? description { get; set; }
        public int quantity { get; set; }
        public float price { get; set; }
        public bool isActive { get; set; }
    }
}
