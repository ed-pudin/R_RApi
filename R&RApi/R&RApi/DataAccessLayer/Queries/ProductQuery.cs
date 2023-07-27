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
        public string editProduct()
        {
            return "UPDATE product set id=@newid, name=@name, description=@description, quantity=@quantity," +
                "price=@price where id=@id";
        }
        public string getProduct()
        {
            return "SELECT * FROM product where id=@id";
        }
        public string getProducts()
        {
            return "SELECT * FROM product";
        }
    }
}
