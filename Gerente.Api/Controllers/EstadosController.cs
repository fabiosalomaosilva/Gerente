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
            return await _estadoService.GetAsync();
        }

        [HttpPost]
        [ClaimsAuth("EstadosAdd")]
        public async Task<IActionResult> Post(EstadoViewModel obj)
        {
            var objResult = await _estadoService.AddAsync(obj);
            return Ok(objResult);
        }

        [HttpPut]
        [ClaimsAuth("EstadosEdit")]
        public async Task<IActionResult> Put(EstadoViewModel obj)
        {
            await _estadoService.EditAsync(obj);
            return Ok();
        }

        [HttpDelete("id")]
        [ClaimsAuth("EstadosDelete")]
        public async Task<IActionResult> Delete(int id)
        {
            await _estadoService.DeleteAsync(id);
            return Ok("Registro excluído com sucesso");
        }
    }
}
