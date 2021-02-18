using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Gerente.Application.Interfaces;
using Gerente.Application.ViewModels;
using Gerente.Domain.Entities;
using Gerente.Domain.Interfaces;

namespace Gerente.Application.Services
{
    public class AditivoService : IAditivoService
    {
        private readonly IAditivoRepository _service;
        private readonly IMapper _mapper;

        public AditivoService(IAditivoRepository service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        public async Task<IEnumerable<AditivoViewModel>> GetAsync()
        {
            var lista = await _service.GetAsync();
            return _mapper.Map<IEnumerable<AditivoViewModel>>(lista);
        }

        public async Task<AditivoViewModel> GetAsync(int? id)
        {
            var obj = await _service.GetAsync(id);
            return _mapper.Map<AditivoViewModel>(obj);
        }

        public async Task<AditivoViewModel> AddAsync(AditivoViewModel obj)
        {
            var objeto = _mapper.Map<Aditivo>(obj);
            var objResult = await _service.AddAsync(objeto);
            return _mapper.Map<AditivoViewModel>(objResult);
        }

        public async Task EditAsync(AditivoViewModel obj)
        {
            var objeto = _mapper.Map<Aditivo>(obj);
            await _service.EditAsync(objeto);
        }

        public async Task DeleteAsync(int id)
        {
            var obj = await _service.GetAsync(id);
            await _service.DeleteAsync(obj);
        }
    }
}