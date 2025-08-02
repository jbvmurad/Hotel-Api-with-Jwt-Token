using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using PatikaTask.Entity;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace PatikaTask.Services
{
    public class JwtService : IJwtService
    {
        private readonly JwtSettings _jwtSettings;
        private readonly AdminCredentials _adminCredentials;

        public JwtService(IOptions<JwtSettings> jwtSettings, IOptions<AdminCredentials> adminCredentials)
        {
            _jwtSettings = jwtSettings.Value;
            _adminCredentials = adminCredentials.Value;
        }

        public string GenerateToken(string email)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.SecretKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(ClaimTypes.Email, email),
                new Claim(ClaimTypes.Role, "Admin")
            };

            var token = new JwtSecurityToken(
                issuer: _jwtSettings.Issuer,
                audience: _jwtSettings.Audience,
                claims: claims,
                expires: DateTime.Now.AddMinutes(_jwtSettings.ExpirationMinutes),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public bool ValidateCredentials(string email, string password)
        {
            return email == _adminCredentials.Email && password == _adminCredentials.Password;
        }
    }
}