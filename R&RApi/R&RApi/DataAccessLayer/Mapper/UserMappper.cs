
using Newtonsoft.Json;
using R_RApi.DataAccessLayer.Models;
using R_RApi.DataAccessLayer.Queries;
using R_RApi.InfrastructureLayer.Authentication;
using System.Data.SqlClient;

namespace R_RApi.DataAccessLayer.Mapper
{
    public class UserMappper
    {
        SqlConnection _connection;
        SqlCommand _command;
        UserQuery _query;
        SqlDataReader _reader;
        public UserMappper() {
            Connection connection = new Connection();
            _connection = connection.sqlCon();

            _query = new UserQuery();
        }
        public string login(string email, string password)
        {
            
            _connection.Open();
            _command = new SqlCommand(_query.login(), _connection);

            _command.Parameters.AddWithValue("@email", email);
            _command.Parameters.AddWithValue("@password", password);

            _reader = _command.ExecuteReader();
            if (_reader.Read()) {

                user user = new user();
                user.id = _reader["id"].ToString();
                user.name = _reader["name"].ToString();
                user.lastname = _reader["lastname"].ToString();
                user.email = _reader["email"].ToString();
                user.password = _reader["password"].ToString();
                user.rol = _reader["rol"].ToString();

                Auth authorization = new Auth(user);

                return JsonConvert.SerializeObject(new
                {
                    status = 1,
                    token = authorization.token
                });
            }
            else {
                return JsonConvert.SerializeObject(new
                {
                    status = 0
                });
            }
        }
    }
}
