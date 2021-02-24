using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Application.Interfaces;
using Gerente.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using System.Linq;
using Gerente.Domain.Entities;
using Microsoft.Extensions.Primitives;

namespace Gerente.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class EstadosController : ControllerBase
    {
        private readonly IEstadoService _service;

        public EstadosController(IEstadoService estadoService)
        {
            _service = estadoService;
        }

        [HttpGet]
        [ClaimsAuth(TipoAction.Get, "Estados")]
        public async Task<ListData> Get([FromQuery] PaginationDTO pagination, [FromQuery] string name)
        {
            //try
            //{
                return await _service.GetAsync(pagination, name);
            //    var count = lista.Count();
            //    var queryString = Request.Query;
            //    var filter = string.Empty;
            //    if (queryString.Keys.Contains("$inlinecount"))
            //    {
            //        StringValues Skip;
            //        StringValues Take;
            //        var list = new List<Estado>();
            //        if (queryString.Keys.Contains("$filter"))
            //        {
            //            filter = queryString.FirstOrDefault(p => p.Key == "$filter").Value[0].Split("'")[1];
            //        }

            //        int skip = (queryString.TryGetValue("$skip", out Skip)) ? Convert.ToInt32(Skip[0]) : 0;
            //        int top = (queryString.TryGetValue("$top", out Take)) ? Convert.ToInt32(Take[0]) : lista.Count();
            //        if (string.IsNullOrEmpty(filter))
            //        {
            //            list = lista.OrderBy(p => p.Nome).Skip(skip).Take(top).ToList();
            //        }
            //        else
            //        {
            //            var array = filter.Split(" ");

            //            foreach (var i in array)
            //            {
            //                var listDoArray = lista.Where(p => p.Nome.Contains(i));
            //                foreach (var s in listDoArray)
            //                {
            //                    if (string.IsNullOrEmpty(list.FirstOrDefault(p => p.Id == s.Id)?.Id.ToString()))
            //                    {
            //                        list.Add(s);
            //                    }
            //                }
            //            }

            //            list = list.OrderBy(p => p.Nome).Skip(skip).Take(top).ToList();
            //        }

            //        return new { Items = list, Count = count };
            //    }

            //    return await lista.ToListAsync();

            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //    throw;
            //}
        }

        [HttpPost]
        [ClaimsAuth(TipoAction.Post, "Estados")]
        public async Task<IActionResult> Post(EstadoViewModel obj)
        {
            var objResult = await _service.AddAsync(obj);
            return Ok(objResult);
        }

        [HttpPut]
        [ClaimsAuth(TipoAction.Put, "Estados")]
        public async Task<IActionResult> Put(EstadoViewModel obj)
        {
            await _service.EditAsync(obj);
            return Ok();
        }

        [HttpDelete("id")]
        [ClaimsAuth(TipoAction.Delete, "Estados")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);
            return Ok("Registro excluído com sucesso");
        }
    }
}
