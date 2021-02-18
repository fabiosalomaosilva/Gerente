using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gerente.Application.Interfaces;
using Gerente.Application.ViewModels;
using Gerente.Domain.Entities;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Gerente.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AditivosController : ControllerBase
    {
        private readonly IAditivoService _aditivoService;

        public AditivosController(IAditivoService aditivoService)
        {
            _aditivoService = aditivoService;
        }

        [HttpGet]
        public async Task<IEnumerable<AditivoViewModel>> Get()
        {
            return await _aditivoService.GetAsync();
        }

    }
}
