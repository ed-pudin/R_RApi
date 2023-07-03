using R_RApi.DataAccessLayer.Queries;
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

        public string addPurchase(string service, float subTotalService, float subTotalProducts,
                                    float payment, float total) 
        {
            _connection.Open();
            _command = new SqlCommand(_query.addPurchase(), _connection);

            _command.Parameters.AddWithValue("@service", service);
            _command.Parameters.AddWithValue("@subtotalService", subTotalService);
            _command.Parameters.AddWithValue("@subtotalProducts", subTotalProducts);
            _command.Parameters.AddWithValue("@payment", payment);
            _command.Parameters.AddWithValue("@total", total);

            int rowsAffected = _command.ExecuteNonQuery();

            return null;

            //ESTO AUN NO ESTA LISTO
        }
    }
}
