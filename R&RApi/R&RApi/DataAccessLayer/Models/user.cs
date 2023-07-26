namespace R_RApi.DataAccessLayer.Models
{
    public class user
    {
        public string? id { get; set; }
        public string? name { get; set; }
        public string? lastname { get; set; }
        public string? email { get; set; }
        public string? password { get; set; }
        public string? rol { get; set; }
        public bool? isActive { get; set; }
    }
}
