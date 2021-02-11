using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gerente.Application.ViewModels;

namespace Gerente.Api.Services
{
    public interface ITokenService
    {
        Token AddToken(UsuarioViewModel user);
    }
    public class TokenService : ITokenService
    {
        private readonly string _apiKey;

        public TokenService(IConfiguration config)
        {
            _apiKey = config.GetSection("ApiKey").Value;
        }

        public Token AddToken(Usuario user, List<Permissao> permissoes)
        {
            if (user != null)
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes(_apiKey);
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = GetClaimsIdentity(user, JsonConvert.SerializeObject(permissoes)),
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
                    clientId = user.ClientId,
                    cargo = user.Cargo,
                    cargoId = user.CargoId,
                    email = user.Email,
                    fotoUri = foto,
                    nomeCompleto = user.NomeCompleto,
                    perfil = user.Perfil,
                    perfilId = user.PerfilId,
                    permissoes = permissoes.ToArray(),
                    setor = user.Setor,
                    setorId = user.SetorId,
                    Id = user.Id,
                    token_type = "bearer"
                };
            }

            return null;
        }

        private static ClaimsIdentity GetClaimsIdentity(Usuario user, string permissoes)
        {
            return new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, user.NomeCompleto),
                    new Claim("Username", user.Email),
                    new Claim("UserId", user.Id),
                    new Claim("ClientId", user.ClientId),
                    new Claim("SecretariaId", user.SecretariaId),
                    new Claim("Secretaria", user.Secretaria),
                    new Claim("SetorId", user.SetorId),
                    new Claim("Setor", user.Setor),
                    new Claim("CargoId", user.CargoId),
                    new Claim("PerfilId", user.PerfilId),
                    new Claim("Permissoes", permissoes),
                    new Claim("Email", user.Email),
                    new Claim("SuperAdministrador", user.SuperAdministrador.ToString()),
                }
            );
        }


    }


}
