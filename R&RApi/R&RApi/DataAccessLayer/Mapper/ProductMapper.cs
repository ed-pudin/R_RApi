using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using R_RApi.DataAccessLayer.Models;
using R_RApi.DataAccessLayer.Queries;
using R_RApi.DomainLayer.Services;
using R_RApi.InfrastructureLayer.Authentication;
using System.Data.SqlClient;
using System.Text.Json;

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

        public ResponseApi addProduct(product p)
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
        public ResponseApi getProduct(string id) {

            List<product> products = new List<product>();

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

                    products.Add(productM);

                    return new ResponseApi(1, 200, "OK", products.Cast<dynamic>().ToList());

                }
                else
                {
                    return new ResponseApi(0, 200, "No se encontraron productos", null);

                }


            }
            catch(Exception ex)
            {
                return new ResponseApi(0, 400, ex.Message, null);
            }

        }
        public ResponseApi getProducts()
        {
            List<product> products = new List<product>();

            try
            {
                _connection.Open();
                _command = new SqlCommand(_query.getProducts(), _connection);

                _reader = _command.ExecuteReader();
                
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
                if(products.Count > 0)
                {
                    return new ResponseApi(1, 200, "OK", products.Cast<dynamic>().ToList());
                }
                else
                {
                    return new ResponseApi(0, 200, "No se encontraron productos", null);

                }
            }
            catch (Exception ex)
            {
                return new ResponseApi(0, 400, ex.Message, null);

            }

        }

    }
}
