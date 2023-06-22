namespace R_RApi.InfrastructureLayer.Authentication
{
    public class Auth
    {
        public Auth(string username, string password) {
            this.GenerateToken(username, password);
        }
        private string GenerateToken(string username, string password)
        {
            return "a";
        }
    }
}
