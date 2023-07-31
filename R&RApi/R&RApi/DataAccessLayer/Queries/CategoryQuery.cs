namespace R_RApi.DataAccessLayer.Queries
{
    public class CategoryQuery
    {
        public CategoryQuery() { }
        public string addCategory()
        {
            return "INSERT INTO category (name) VALUES (@name)";
        }
        public string editCategory()
        {
            return "UPDATE category SET name=@name where id=@id";
        }
        public string getCategories()
        {
            return "SELECT * FROM category";
        }
    }
}
