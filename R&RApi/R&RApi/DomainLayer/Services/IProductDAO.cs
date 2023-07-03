namespace R_RApi.DomainLayer.Services
{
    public interface IProductDAO
    {
        public string addProduct(string name, string description, int quantity, float price, bool isActive);

        public string getProduct(string id, string name, string description, int quantity, float price, bool isActive);

    }
}
