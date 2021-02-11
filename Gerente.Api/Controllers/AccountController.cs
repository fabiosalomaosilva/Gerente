using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gerente.Application.Interfaces;
using Gerente.Domain.Entities;
using Microsoft.AspNetCore.Authorization;

namespace Gerente.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _service;

        public AccountController(IAccountService service)
        {
            _service = service;
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("Token")]
        public async Task<ActionResult> Token(User user)
        {
        }
    }
}
