namespace R_RApi.DataAccessLayer.Queries
{
    public class CategoryQuery
    {
        public CategoryQuery() { }
        public string addCategory()
        {
            return "INSERT INTO category (name) VALUES (@name)";
        }
    }
}
