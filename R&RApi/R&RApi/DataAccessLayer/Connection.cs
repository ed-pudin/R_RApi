using System.Data.SqlClient;


namespace R_RApi.DataAccessLayer
{
    public class Connection
    {
        SqlConnection conn;
        public Connection() { }

        public SqlConnection sqlCon() {

            //ConfigurationBuilder para construir la configuración a partir del archivo appsettings.json.
            var configurationBuilder = new ConfigurationBuilder()
                                            .SetBasePath(Directory.GetCurrentDirectory())
                                            .AddJsonFile("appsettings.json");
            // Luego, utilizamos IConfiguration para acceder a los valores del archivo de configuración.
            IConfiguration configuration = configurationBuilder.Build();
            // Mediante el método GetConnectionString, podemos obtener la cadena de conexión específica que necesitamos pasando el nombre correspondiente.
            string connectionString = configuration.GetConnectionString("defaultConnection");

            this.conn = new SqlConnection(connectionString);

            return conn; 
        }
        public void open(SqlConnection connectionString) { connectionString.Open(); }
        public void close(SqlConnection connectionString) { connectionString.Close(); }
    }
}
