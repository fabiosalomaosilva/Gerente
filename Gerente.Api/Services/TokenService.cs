using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Gerente.Application.Models;
using Gerente.Application.ViewModels;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Gerente.Api.Services
{
    public class TokenService : ITokenService
    {
        private readonly string _apiKey;

        public TokenService(IConfiguration config)
        {
            _apiKey = config.GetSection("ApiKey").Value;
        }

        public Token AddToken(UsuarioViewModel user)
        {
            if (user != null)
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes(_apiKey);
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = GetClaimsIdentity(user),
                    Expires = DateTime.UtcNow.AddHours(2),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),
                        SecurityAlgorithms.HmacSha256Signature)
                };
                var token = tokenHandler.CreateToken(tokenDescriptor);
                var t = tokenHandler.WriteToken(token);
                var data = DateTime.Now;
                var foto = "";
                if (!string.IsNullOrEmpty(user.Foto))
                {
                    foto = user.Foto;
                }
                return new Token
                {
                    access_token = t,
                    expires = data.AddDays(7).Second.ToString(),
                    email = user.Email,
                    fotoUri = foto,
                    nomeCompleto = user.NomeCompleto,
                    setor = user.Setor,
                    setorId = user.SetorId,
                    secretaria = user.Secretaria,
                    secretariaId = user.SecretariaId,
                    id = user.Id,
                    token_type = "bearer"
                };
            }

            return null;
        }

        private static ClaimsIdentity GetClaimsIdentity(UsuarioViewModel user)
        {
            return new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, user.NomeCompleto),
                    new Claim("Username", user.Email),
                    new Claim("UserId", user.Id),
                    new Claim("SecretariaId", user.SecretariaId.ToString()),
                    new Claim("Secretaria", user.Secretaria),
                    new Claim("SetorId", user.SetorId.ToString()),
                    new Claim("Setor", user.Setor),
                    new Claim("Email", user.Email),
                    new Claim("FotoUri", user.Foto),
                }
            );
        }
    }
}