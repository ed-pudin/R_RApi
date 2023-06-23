namespace R_RApi.DataAccessLayer.Models
{
    public class productCategories
    {
        public string? id { get; set; }
        public int productFK { get; set; }
        public string categoryFK { get; set; }
    }
}
