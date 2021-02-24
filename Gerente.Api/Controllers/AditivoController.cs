using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Application.Interfaces;
using Gerente.Application.ViewModels;


namespace Gerente.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AditivosController : ControllerBase
    {
        private readonly IAditivoService _aditivoService;

        public AditivosController(IAditivoService AditivoService)
        {
            _aditivoService = AditivoService;
        }

        [HttpGet]
        [ClaimsAuth(TipoAction.Get, "Aditivos")]
        public async Task<IEnumerable<AditivoViewModel>> Get()
        {
            return await _aditivoService.GetAsync();
        }

        [HttpPost]
        [ClaimsAuth(TipoAction.Post, "Aditivos")]
        public async Task<IActionResult> Post(AditivoViewModel obj)
        {
            var objResult = await _aditivoService.AddAsync(obj);
            return Ok(objResult);
        }

        [HttpPut]
        [ClaimsAuth(TipoAction.Put, "Aditivos")]
        public async Task<IActionResult> Put(AditivoViewModel obj)
        {
            await _aditivoService.EditAsync(obj);
            return Ok();
        }

        [HttpDelete("id")]
        [ClaimsAuth(TipoAction.Delete, "Aditivos")]
        public async Task<IActionResult> Delete(int id)
        {
            await _aditivoService.DeleteAsync(id);
            return Ok("Registro excluído com sucesso");
        }
    }
}
