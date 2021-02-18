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
        public async Task<IEnumerable<MunicipioViewModel>> Get()
        {
            var lista = await _service.Get();
            return _mapper.Map<IEnumerable<MunicipioViewModel>>(lista);
        }

        public async Task<MunicipioViewModel> Get(int? id)
        {
            var obj = await _service.Get(id);
            return _mapper.Map<MunicipioViewModel>(obj);
        }

        public void Add(MunicipioViewModel obj)
        {
            var objeto = _mapper.Map<Municipio>(obj);
            _service.Add(objeto);
        }

        public void Edit(MunicipioViewModel obj)
        {
            var objeto = _mapper.Map<Municipio>(obj);
            _service.Edit(objeto);
        }

        public void Delete(int id)
        {
            var obj = _service.Get(id).Result;
            _service.Delete(obj);
        }
    }
}