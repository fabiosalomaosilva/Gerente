using Gerente.Application.Models;
using Gerente.Application.ViewModels;

namespace Gerente.Api.Services
{
    public interface ITokenService
    {
        Token AddToken(UsuarioViewModel user);
    }
}
