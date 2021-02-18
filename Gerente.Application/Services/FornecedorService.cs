using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Gerente.Application.Interfaces;
using Gerente.Application.ViewModels;
using Gerente.Domain.Entities;
using Gerente.Domain.Interfaces;

namespace Gerente.Application.Services
{
    public class FornecedorService : IFornecedorService
    {
        private readonly IPessoaRepository _service;
        private readonly IMapper _mapper;

        public FornecedorService(IPessoaRepository service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        public async Task<IEnumerable<FornecedorViewModel>> Get()
        {
            var lista = await _service.Get();
            return _mapper.Map<IEnumerable<FornecedorViewModel>>(lista);
        }

        public async Task<FornecedorViewModel> Get(int? id)
        {
            var obj = await _service.Get(id);
            return _mapper.Map<FornecedorViewModel>(obj);
        }

        public void Add(FornecedorViewModel obj)
        {
            var objeto = _mapper.Map<Pessoa>(obj);
            _service.Add(objeto);
        }

        public void Edit(FornecedorViewModel obj)
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