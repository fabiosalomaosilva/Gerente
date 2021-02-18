using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Gerente.Application.Interfaces;
using Gerente.Application.ViewModels;
using Gerente.Domain.Entities;
using Gerente.Domain.Interfaces;

namespace Gerente.Application.Services
{
    public class LocalProcedimentoService : ILocalProcedimentoService
    {
        private readonly ILocalProcedimentoRepository _service;
        private readonly IMapper _mapper;

        public LocalProcedimentoService(ILocalProcedimentoRepository service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        public async Task<IEnumerable<LocalProcedimentoViewModel>> Get()
        {
            var lista = await _service.Get();
            return _mapper.Map<IEnumerable<LocalProcedimentoViewModel>>(lista);
        }

        public async Task<LocalProcedimentoViewModel> Get(int? id)
        {
            var obj = await _service.Get(id);
            return _mapper.Map<LocalProcedimentoViewModel>(obj);
        }

        public void Add(LocalProcedimentoViewModel obj)
        {
            var objeto = _mapper.Map<LocalProcedimento>(obj);
            _service.Add(objeto);
        }

        public void Edit(LocalProcedimentoViewModel obj)
        {
            var objeto = _mapper.Map<LocalProcedimento>(obj);
            _service.Edit(objeto);
        }

        public void Delete(int id)
        {
            var obj = _service.Get(id).Result;
            _service.Delete(obj);
        }
    }
}