using R_RApi.DataAccessLayer.Models;
using R_RApi.DataAccessLayer.Queries;
using R_RApi.DataAccessLayer.Response;
using System.Data.SqlClient;

namespace R_RApi.DataAccessLayer.Mapper
{
    public class PurchaseMapper
    {
        SqlConnection _connection;
        SqlCommand _command;
        PurchaseQuery _query;
        SqlDataReader _reader;

        public PurchaseMapper() 
        {
            Connection connection = new Connection();
            _connection = connection.sqlCon();

            _query = new PurchaseQuery();
        }

        public ResponseApi addPurchase(purchase pu) 
        {
            try
            {
                _connection.Open();
                _command = new SqlCommand(_query.addPurchase(), _connection);

                _command.Parameters.AddWithValue("@service", pu.service);
                _command.Parameters.AddWithValue("@subtotalService", pu.subTotalService);
                _command.Parameters.AddWithValue("@subtotalProducts", pu.subTotalProducts);
                _command.Parameters.AddWithValue("@change", pu.change);
                _command.Parameters.AddWithValue("@payment", pu.payment);
                _command.Parameters.AddWithValue("@total", pu.total);

                if(_command.ExecuteNonQuery() > 0)
                {
                    return new ResponseApi(1, 200, "Ok", null);
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
