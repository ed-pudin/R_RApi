namespace R_RApi.DataAccessLayer.Queries
{
    public class ProductQuery
    {
        public ProductQuery() { }

        public string addProduct() 
        {
            return "INSERT INTO product (id, name, description, quantity, price)" +
                    "VALUES (@id, @name, @description, @quantity, @price)";
        }

        public string getProduct()
        {
            return "SELECT * FROM product where id=@id";
        }
    }
}
