
using Newtonsoft.Json;
using R_RApi.DataAccessLayer.Models;
using R_RApi.DataAccessLayer.Queries;
using R_RApi.DataAccessLayer.Response;
using R_RApi.InfrastructureLayer.Authentication;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Net;

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
        public ResponseApi login(string email, string password)
        {
            try
            {
                _connection.Open();
                _command = new SqlCommand(_query.login(), _connection);

                _command.Parameters.AddWithValue("@email", email);
                _command.Parameters.AddWithValue("@password", password);

                _reader = _command.ExecuteReader();
                if (_reader.Read())
                {

                    user user = new user();
                    user.id = _reader["id"].ToString();
                    user.name = _reader["name"].ToString();
                    user.lastname = _reader["lastname"].ToString();
                    user.email = _reader["email"].ToString();
                    user.password = _reader["password"].ToString();
                    user.rol = _reader["rol"].ToString();

                    Auth authorization = new Auth(user);


                    List<string> list = new List<string>();
                    list.Add(authorization.token);

                    return new ResponseApi(1, 200, "OK", list.Cast<dynamic>().ToList());
                }
                else
                {
                    return new ResponseApi(0, 200, "Error al entrar", null);
                }
            }
            catch (Exception ex)
            {
                return new ResponseApi(0, 400, ex.Message, null);
            }
            
        }
        public ResponseApi signup(user u)
        {
            try
            {
                _connection.Open();
                _command = new SqlCommand(_query.signup(), _connection);

                _command.Parameters.AddWithValue("@name", u.name);
                _command.Parameters.AddWithValue("@lastname", u.lastname);
                _command.Parameters.AddWithValue("@email", u.email);
                _command.Parameters.AddWithValue("@password", u.password);
                _command.Parameters.AddWithValue("@rol", "client");

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
        public ResponseApi editClient(user u)
        {
            try
            {
                _connection.Open();
                _command = new SqlCommand(_query.editClient(), _connection);

                _command.Parameters.AddWithValue("@id", u.id);
                _command.Parameters.AddWithValue("@name", u.name);
                _command.Parameters.AddWithValue("@lastname", u.lastname);
                _command.Parameters.AddWithValue("@email", u.email);
                _command.Parameters.AddWithValue("@password", u.password);
                _command.Parameters.AddWithValue("@rol", u.rol);

                if (_command.ExecuteNonQuery() > 0)
                {
                    return new ResponseApi(1, 200, "OK", null);
                }
                else
                {
                    return new ResponseApi(0, 200, "Error al editar", null);
                }
            }
            catch (Exception ex)
            {
                return new ResponseApi(0, 400, ex.Message, null);
            }
        }
        public ResponseApi deleteClient(user u)
        {
            try
            {
                _connection.Open();
                _command = new SqlCommand(_query.deleteClient(), _connection);

                _command.Parameters.AddWithValue("@id", u.id);
                _command.Parameters.AddWithValue("@name", u.name);
                _command.Parameters.AddWithValue("@lastname", u.lastname);
                _command.Parameters.AddWithValue("@email", u.email);
                _command.Parameters.AddWithValue("@password", u.password);
                _command.Parameters.AddWithValue("@isActive", u.isActive);
                _command.Parameters.AddWithValue("@rol", u.rol);

                if (_command.ExecuteNonQuery() > 0)
                {
                    return new ResponseApi(1, 200, "OK", null);
                }
                else
                {
                    return new ResponseApi(0, 200, "Error al editar", null);
                }
            }
            catch (Exception ex)
            {
                return new ResponseApi(0, 400, ex.Message, null);
            }

        }

    }
}
