using R_RApi.DataAccessLayer.Models;
using R_RApi.DataAccessLayer.Queries;
using R_RApi.DataAccessLayer.Response;
using System.Data.SqlClient;

namespace R_RApi.DataAccessLayer.Mapper
{
    public class CategoryMapper
    {
        SqlConnection _connection;
        SqlCommand _command;
        CategoryQuery _query;
        SqlDataReader _reader;

        public CategoryMapper()
        {
            Connection connection = new Connection();
            _connection = connection.sqlCon();

            _query = new CategoryQuery();
        }
        public ResponseApi addCategory(category c)
        {
            try
            {
                _connection.Open();
                _command = new SqlCommand(_query.addCategory(), _connection);

                _command.Parameters.AddWithValue("@name", c.name);

                if (_command.ExecuteNonQuery() > 0)
                {
                    return new ResponseApi(1, 200, "OK", null);
                }
                else
                {
                    return new ResponseApi(0, 200, "Error al registrar", null);

                }
            }
            catch (Exception ex)
            {
                return new ResponseApi(0, 400, ex.Message, null);
            }

        }

    }
}
