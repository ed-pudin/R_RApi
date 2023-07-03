namespace R_RApi.DataAccessLayer.Queries
{
    public class ProductQuery
    {
        public ProductQuery() { }

        public string addProduct() 
        {
            return "INSERT INTO product (name, description, quantity, price, isActive)" +
                    "VALUES (@name, @description, @quantity, @price, @isActive)";
        }

        public string getProduct()
        {
            return "SELECT * FROM product";
        }
    }
}
