using Newtonsoft.Json;
using R_RApi.DataAccessLayer.Models;
using R_RApi.DataAccessLayer.Queries;
using R_RApi.InfrastructureLayer.Authentication;
using System.Data.SqlClient;

namespace R_RApi.DataAccessLayer.Mapper
{
    public class ProductMapper
    {
        SqlConnection _connection;
        SqlCommand _command;
        ProductQuery _query;
        SqlDataReader _reader;

        public ProductMapper() 
        {
            Connection connection = new Connection();
            _connection = connection.sqlCon();

            _query = new ProductQuery();
        }

        public string addProduct(product p)
        {
            try
            {
                _connection.Open();
                _command = new SqlCommand(_query.addProduct(), _connection);

                _command.Parameters.AddWithValue("@id", p.id);
                _command.Parameters.AddWithValue("@name", p.name);
                _command.Parameters.AddWithValue("@description", p.description);
                _command.Parameters.AddWithValue("@quantity", p.quantity);
                _command.Parameters.AddWithValue("@price", p.price);

                if (_command.ExecuteNonQuery() > 0)
                {
                    return JsonConvert.SerializeObject(new
                    {
                        status = 1,
                    });
                }
                else
                {
                    return JsonConvert.SerializeObject(new
                    {
                        status = 0,
                    });
                }
            }
            catch (Exception ex)
            {
                return JsonConvert.SerializeObject(new
                {
                    status = ex.Message,
                });
            }

        }

        public string getProduct(string id) {
            

            try
            {
                _connection.Open();
                _command = new SqlCommand(_query.getProduct(), _connection);

                _command.Parameters.AddWithValue("@id", id);

                _reader = _command.ExecuteReader();
                if (_reader.Read())
                {
                   
                    product productM = new product
                    {
                        id = _reader["id"].ToString(),
                        name = _reader["name"].ToString(),
                        description = _reader["description"].ToString(),
                        quantity = Convert.ToInt32(_reader["quantity"]),
                        price = Convert.ToSingle(_reader["price"]),
                        isActive = Convert.ToBoolean(_reader["isActive"])
                    };
                    
                    return JsonConvert.SerializeObject(productM);

                }
                else
                {
                    return JsonConvert.SerializeObject(new
                    {
                        status = 0
                    });
                }
               
               
            }
            catch(Exception ex)
            {
                return JsonConvert.SerializeObject(new
                {
                    status = ex.Message
                });
            }

        }
    }
}
