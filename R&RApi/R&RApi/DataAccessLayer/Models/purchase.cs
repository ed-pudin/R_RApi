namespace R_RApi.DataAccessLayer.Models
{
    public class purchase
    {
        public string? id { get; set; }
        public string? service { get; set; }
        public float? subTotalService { get; set; }
        public float? subTotalProducts { get; set; }
        public float? payment { get; set; }
        public float? total { get; set; }
    }
}
