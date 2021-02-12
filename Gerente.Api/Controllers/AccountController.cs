﻿using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Gerente.Api.Services;
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
            var result = await _service.Login(user);
            if (result.Succeeded == false)
                return NotFound(new { message = result.Error});
            return _tokenService.AddToken(result.Usuario);
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("Register")]
        public async Task<ActionResult> Register([FromBody] UsuarioViewModel user)
        {
            var result = await _service.Register(user);
            if (result == false)
                return NotFound(new { message = "Ocorreu um erro ao salvar o usuário" });
            return Ok(user);
        }
    }
}
