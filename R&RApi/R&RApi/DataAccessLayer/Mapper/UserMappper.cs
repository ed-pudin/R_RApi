
using Newtonsoft.Json;
using R_RApi.DataAccessLayer.Queries;
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
                return JsonConvert.SerializeObject(new
                {
                    status = 1
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
