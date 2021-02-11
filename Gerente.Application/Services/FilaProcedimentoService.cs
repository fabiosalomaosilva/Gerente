using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Gerente.Application.Interfaces;
using Gerente.Application.ViewModels;
using Gerente.Domain.Entities;
using Gerente.Domain.Interfaces;

namespace Gerente.Application.Services
{
    public class FilaProcedimentoService : IFilaProcedimentoService
    {
        private readonly IFilaProcedimentoRepository _service;
        private readonly IMapper _mapper;

        public FilaProcedimentoService(IFilaProcedimentoRepository service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        public async Task<IEnumerable<FilaProcedimentoViewModel>> Get()
        {
            var lista = await _service.Get();
            return _mapper.Map<IEnumerable<FilaProcedimentoViewModel>>(lista);
        }

        public async Task<FilaProcedimentoViewModel> Get(int? id)
        {
            var obj = await _service.Get(id);
            return _mapper.Map<FilaProcedimentoViewModel>(obj);
        }

        public void Add(FilaProcedimentoViewModel obj, string nomeUsuario)
        {
            var objeto = _mapper.Map<FilaProcedimento>(obj);
            _service.Add(objeto, nomeUsuario);
        }

        public void Edit(FilaProcedimentoViewModel obj, string nomeUsuario)
        {
            var objeto = _mapper.Map<FilaProcedimento>(obj);
            _service.Edit(objeto, nomeUsuario);
        }

        public void Delete(int id, string nomeUsuario)
        {
            var obj = _service.Get(id).Result;
            _service.Delete(obj, nomeUsuario);
        }
    }
}