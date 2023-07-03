using Newtonsoft.Json;
using R_RApi.DataAccessLayer.Models;
using R_RApi.DataAccessLayer.Queries;
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

        //public string AddProduct(string name, string description, int quantity, float price, bool isActive)
        //{
        //    try
        //    {
        //        if (string.IsNullOrEmpty(name) || quantity <= 0)
        //        {
        //            var successMessage = new { message = "Los datos del producto son incorrectos." };
        //            return JsonConvert.SerializeObject(successMessage);
        //            //Console.WriteLine("Los datos del producto son incorrectos");
        //        }

        //        _connection.Open();
        //        _command = new SqlCommand(_query.addProduct(), _connection);

        //        _command.Parameters.AddWithValue("@name", name);
        //        _command.Parameters.AddWithValue("@description", description);
        //        _command.Parameters.AddWithValue("@quantity", quantity);
        //        _command.Parameters.AddWithValue("@price", price);
        //        _command.Parameters.AddWithValue("@isActive", isActive);

        //        int rowsAffected = _command.ExecuteNonQuery();

        //        if (rowsAffected > 0)
        //        {
        //            var successMessage = new { message = "El producto se ha agregado correctamente." };
        //            return JsonConvert.SerializeObject(successMessage);
        //            //Console.WriteLine("El producto se ha agregado correctamente.");
        //        }
        //        else
        //        {
        //            var errorMessage = new { message = "El producto se ha agregado correctamente." };
        //            return JsonConvert.SerializeObject(errorMessage);
        //            //Console.WriteLine("No se pudo agregar el producto.");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Error: " + ex.Message);
        //    }
            
        //}

        public string GetProduct(string id, string name, string description, int quantity, float price, bool isActive) {
            
            List<product> products = new List<product>();

            try
            {
                _connection.Open();
                _command = new SqlCommand(_query.getProduct(), _connection);

                _command.Parameters.AddWithValue("@id", id);
                _command.Parameters.AddWithValue("@name",name);
                _command.Parameters.AddWithValue("@description", description);
                _command.Parameters.AddWithValue("@quantity", quantity);
                _command.Parameters.AddWithValue("@price", price);
                _command.Parameters.AddWithValue("@isActive", isActive);

                while (_reader.Read())
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
                    products.Add(productM);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return JsonConvert.SerializeObject(products);
        }
    }
}
