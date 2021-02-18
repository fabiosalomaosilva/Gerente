using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Gerente.Application.Interfaces;
using Gerente.Application.ViewModels;
using Gerente.Domain.Entities;
using Gerente.Domain.Interfaces;

namespace Gerente.Application.Services
{
    public class PacienteService : IPacienteService
    {
        private readonly IPessoaRepository _service;
        private readonly IMapper _mapper;

        public PacienteService(IPessoaRepository service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        public async Task<IEnumerable<PacienteViewModel>> Get()
        {
            var lista = await _service.Get();
            return _mapper.Map<IEnumerable<PacienteViewModel>>(lista);
        }

        public async Task<PacienteViewModel> Get(int? id)
        {
            var obj = await _service.Get(id);
            return _mapper.Map<PacienteViewModel>(obj);
        }

        public void Add(PacienteViewModel obj)
        {
            var objeto = _mapper.Map<Pessoa>(obj);
            _service.Add(objeto);
        }

        public void Edit(PacienteViewModel obj)
        {
            var objeto = _mapper.Map<Pessoa>(obj);
            _service.Edit(objeto);
        }

        public void Delete(int id)
        {
            var obj = _service.Get(id).Result;
            _service.Delete(obj);
        }
    }
}