using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Gerente.Api.Services;
using Gerente.Api.Utils;
using Gerente.Application.Interfaces;
using Gerente.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace Gerente.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _service;
        private readonly ITokenService _tokenService;

        public AccountController(IAccountService service, ITokenService tokenService)
        {
            _service = service;
            _tokenService = tokenService;
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("Login")]
        public async Task<ActionResult<dynamic>> Login([FromBody] UserLoginViewModel user)
        {
            var result = await _service.LoginAsync(user);
            if (result.Succeeded == false)
                return NotFound(new { message = result.Error});
            var claims = await _service.GetClaimsAsync(result.Role);
            return _tokenService.AddToken(result.Usuario, claims);
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("Register")]
        public async Task<ActionResult> Register([FromBody] UsuarioViewModel user)
        {
            var sexo = (await DefinirSexoService.GetSexo(user.NomeCompleto.GetFirstName())).Sexo;
            user.Sexo = sexo;
            user.Foto = DefinirImagenService.SelecionarAvatar(sexo);
            user.FotoExtensao = ".png";

            var result = await _service.RegisterAsync(user, user.NomeRole);
            if (result == false)
                return NotFound(new { message = "Ocorreu um erro ao salvar o usuário" });
            return Ok(user);
        }
    }
}
