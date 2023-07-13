using R_RApi.DataAccessLayer.Models;

namespace R_RApi.DataAccessLayer.Queries
{
    public class UserQuery
    {
        public UserQuery() { }
        public string login()
        {
            return "SELECT * FROM [user] WHERE email = @email and password = @password";
        }
        public string signup(user u)
        {
            return "INSERT INTO [user](name, lastname, email, password, rol) values(@name,@lastname,@email,@password,@rol)";
        }
    }
}
