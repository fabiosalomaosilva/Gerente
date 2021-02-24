using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Text.RegularExpressions;
using AutoMapper;
using Gerente.Application.Models;
using Gerente.Application.ViewModels;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;

namespace Gerente.Api.Services
{
    public class TokenService : ITokenService
    {
        private readonly string _apiKey;
        private readonly IMapper mapper;

        public TokenService(IConfiguration config, IMapper mapper)
        {
            _apiKey = config.GetSection("ApiKey").Value;
            this.mapper = mapper;
        }

        public Token AddToken(UsuarioViewModel user, IEnumerable<RoleClaimViewModel> claims)
        {
            if (user != null)
            {
                var listaPermissoes = ListarPermissoes(claims);
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes(_apiKey);
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = GetClaimsIdentity(user, claims),
                    Expires = DateTime.UtcNow.AddHours(500),
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

                //var claimss = mapper.Map<IEnumerable<ClaimViewModel>>(claims);

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
                    permissoes = listaPermissoes,
                    token_type = "bearer"
                };
            }

            return null;
        }

        private static ClaimsIdentity GetClaimsIdentity(UsuarioViewModel user, IEnumerable<RoleClaimViewModel> claims)
        {
            return new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, user.NomeCompleto),
                    new Claim("Username", user.Email),
                    //new Claim("UserId", user.Id),
                    new Claim("SecretariaId", user.SecretariaId.ToString()),
                    new Claim("Secretaria", user.Secretaria),
                    new Claim("SetorId", user.SetorId.ToString()),
                    new Claim("Setor", user.Setor),
                    new Claim("Email", user.Email),
                    new Claim("FotoUri", user.Foto),
                    new Claim("Permissoes", JsonConvert.SerializeObject(claims)),
                }
            );
        }

        private string ListarPermissoes(IEnumerable<RoleClaimViewModel> lista)
        {
            var list = new Dictionary<string, string>();
            foreach (var i in lista)
            {
                list.Add(i.ClaimType, i.ClaimValue);
            }
            return JsonConvert.SerializeObject(list);
        }
    }
}