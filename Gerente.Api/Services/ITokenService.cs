using System.Collections.Generic;
using Gerente.Application.Models;
using Gerente.Application.ViewModels;
using Gerente.Domain.Entities;

namespace Gerente.Api.Services
{
    public interface ITokenService
    {
        Token AddToken(UsuarioViewModel user, IEnumerable<RoleClaimViewModel> claims);
    }
}
