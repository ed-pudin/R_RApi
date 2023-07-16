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
        public string signup()
        {
            return "INSERT INTO [user](name, lastname, email, password, rol) values(@name,@lastname,@email,@password,@rol)";
        }
        public string editClient()
        {
            return "UPDATE [user] SET name=@name, lastname=@lastname, email=@email, password=@password where id=@id";
        }
        public string deleteClient()
        {
            return "UPDATE [user] SET name=@name, lastname=@lastname, email=@email, password=@password, isActive=@isActive where id=@id";
        }
    }
}
