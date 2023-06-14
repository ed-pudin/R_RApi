namespace R_RApi.DataAccessLayer.Queries
{
    public class UserQuery
    {
        public UserQuery() { }
        public string login()
        {
            return "SELECT * FROM [user] WHERE email = @email and password = @password";
        }
    }
}
