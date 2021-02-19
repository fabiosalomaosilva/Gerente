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
        public async Task<IEnumerable<FornecedorViewModel>> GetAsync()
        {
            var lista = await _service.GetAsync();
            return _mapper.Map<IEnumerable<FornecedorViewModel>>(lista);
        }

        public async Task<FornecedorViewModel> GetAsync(int? id)
        {
            var obj = await _service.GetAsync(id);
            return _mapper.Map<FornecedorViewModel>(obj);
        }

        public async Task<FornecedorViewModel> AddAsync(FornecedorViewModel obj)
        {
            var objeto = _mapper.Map<Pessoa>(obj);
            var objetoResult = await _service.AddAsync(objeto);
            return _mapper.Map<FornecedorViewModel>(objetoResult);
        }

        public async Task EditAsync(FornecedorViewModel obj)
        {
            var objeto = _mapper.Map<Pessoa>(obj);
            await _service.EditAsync(objeto);
        }

        public async Task DeleteAsync(int id)
        {
            var obj = await _service.GetAsync(id);
            await _service.DeleteAsync(obj);
        }
    }
}