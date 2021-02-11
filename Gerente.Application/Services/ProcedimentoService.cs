using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Gerente.Application.Interfaces;
using Gerente.Application.ViewModels;
using Gerente.Domain.Entities;
using Gerente.Domain.Interfaces;

namespace Gerente.Application.Services
{
    public class ProcedimentoService : IProcedimentoService
    {
        private readonly IProcedimentoRepository _service;
        private readonly IMapper _mapper;

        public ProcedimentoService(IProcedimentoRepository service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        public async Task<IEnumerable<ProcedimentoViewModel>> Get()
        {
            var lista = await _service.Get();
            return _mapper.Map<IEnumerable<ProcedimentoViewModel>>(lista);
        }

        public async Task<ProcedimentoViewModel> Get(int? id)
        {
            var obj = await _service.Get(id);
            return _mapper.Map<ProcedimentoViewModel>(obj);
        }

        public void Add(ProcedimentoViewModel obj, string nomeUsuario)
        {
            var objeto = _mapper.Map<Procedimento>(obj);
            _service.Add(objeto, nomeUsuario);
        }

        public void Edit(ProcedimentoViewModel obj, string nomeUsuario)
        {
            var objeto = _mapper.Map<Procedimento>(obj);
            _service.Edit(objeto, nomeUsuario);
        }

        public void Delete(int id, string nomeUsuario)
        {
            var obj = _service.Get(id).Result;
            _service.Delete(obj, nomeUsuario);
        }
    }
}