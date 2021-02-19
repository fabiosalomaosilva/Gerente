using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Gerente.Application.Interfaces;
using Gerente.Application.ViewModels;
using Gerente.Domain.Entities;
using Gerente.Domain.Interfaces;

namespace Gerente.Application.Services
{
    public class SetorService : ISetorService
    {
        private readonly ISetorRepository _service;
        private readonly IMapper _mapper;

        public SetorService(ISetorRepository service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        public async Task<IEnumerable<SetorViewModel>> GetAsync()
        {
            var lista = await _service.GetAsync();
            return _mapper.Map<IEnumerable<SetorViewModel>>(lista);
        }

        public async Task<SetorViewModel> GetAsync(int? id)
        {
            var obj = await _service.GetAsync(id);
            return _mapper.Map<SetorViewModel>(obj);
        }

        public async Task<SetorViewModel> AddAsync(SetorViewModel obj)
        {
            var objeto = _mapper.Map<Setor>(obj);
            var objetoResult = await _service.AddAsync(objeto);
            return _mapper.Map<SetorViewModel>(objetoResult);
        }

        public async Task EditAsync(SetorViewModel obj)
        {
            var objeto = _mapper.Map<Setor>(obj);
            await _service.EditAsync(objeto);
        }

        public async Task DeleteAsync(int id)
        {
            var obj = await _service.GetAsync(id);
            await _service.DeleteAsync(obj);
        }
    }
}