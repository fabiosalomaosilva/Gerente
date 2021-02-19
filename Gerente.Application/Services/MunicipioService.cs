using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Gerente.Application.Interfaces;
using Gerente.Application.ViewModels;
using Gerente.Domain.Entities;
using Gerente.Domain.Interfaces;

namespace Gerente.Application.Services
{
    public class MunicipioService : IMunicipioService
    {
        private readonly IMunicipioRepository _service;
        private readonly IMapper _mapper;

        public MunicipioService(IMunicipioRepository service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        public async Task<IEnumerable<MunicipioViewModel>> GetAsync()
        {
            var lista = await _service.GetAsync();
            return _mapper.Map<IEnumerable<MunicipioViewModel>>(lista);
        }

        public async Task<MunicipioViewModel> GetAsync(int? id)
        {
            var obj = await _service.GetAsync(id);
            return _mapper.Map<MunicipioViewModel>(obj);
        }

        public async Task<MunicipioViewModel> AddAsync(MunicipioViewModel obj)
        {
            var objeto = _mapper.Map<Municipio>(obj);
            var objetoResult = await _service.AddAsync(objeto);
            return _mapper.Map<MunicipioViewModel>(objetoResult);
        }

        public async Task EditAsync(MunicipioViewModel obj)
        {
            var objeto = _mapper.Map<Municipio>(obj);
            await _service.EditAsync(objeto);
        }

        public async Task DeleteAsync(int id)
        {
            var obj = await _service.GetAsync(id);
            await _service.DeleteAsync(obj);
        }
    }
}