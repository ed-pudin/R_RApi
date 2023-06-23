using R_RApi.DataAccessLayer.Models;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.IdentityModel.Tokens.Jwt;

namespace R_RApi.InfrastructureLayer.Authentication
{
    public class Auth
    {
        public string token { get; set; }
        private IConfiguration config;
        public Auth(user u) {
            var configurationBuilder = new ConfigurationBuilder()
                                            .SetBasePath(Directory.GetCurrentDirectory())
                                            .AddJsonFile("appsettings.json");

            this.config = configurationBuilder.Build();
            this.token = this.GenerateToken(u);

        }
        private string GenerateToken(user u)
        {
            //Claim, conjunto de valores con la identidad del usuario asociado al token

            var claims = new[]
            {
                new Claim(ClaimTypes.Email, u.email),
                new Claim(ClaimTypes.Name, u.name + " " + u.lastname),
                new Claim(ClaimTypes.Role, u.rol),
                new Claim("Id", u.id)
            };

            var superkey= config.GetSection("JWT:Key").Value;
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(superkey));            // Crear una clave simétrica
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature); //llave digital. Encriptacion decla llave

            var securityToken = new JwtSecurityToken(
                                claims: claims,
                                signingCredentials: creds,
                                expires: DateTime.Now.AddMinutes(60)
                                );

            return new JwtSecurityTokenHandler().WriteToken(securityToken); //serializacion del token
        }
    }
}
