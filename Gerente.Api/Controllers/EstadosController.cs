using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Application.Interfaces;
using Gerente.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace Gerente.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class EstadosController : ControllerBase
    {
        private readonly IEstadoService _estadoService;

        public EstadosController(IEstadoService estadoService)
        {
            _estadoService = estadoService;
        }

        [HttpGet]
        [ClaimsAuth("EstadosView")]
        public async Task<IEnumerable<EstadoViewModel>> Get()
        {
            return await _estadoService.Get();
        }
    }
}
