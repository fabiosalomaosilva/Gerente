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
        public async Task<IEnumerable<PacienteViewModel>> GetAsync()
        {
            var lista = await _service.GetAsync();
            return _mapper.Map<IEnumerable<PacienteViewModel>>(lista);
        }

        public async Task<PacienteViewModel> GetAsync(int? id)
        {
            var obj = await _service.GetAsync(id);
            return _mapper.Map<PacienteViewModel>(obj);
        }

        public async Task<PacienteViewModel> AddAsync(PacienteViewModel obj)
        {
            var objeto = _mapper.Map<Pessoa>(obj);
            var objetoResult = await _service.AddAsync(objeto);
            return _mapper.Map<PacienteViewModel>(objetoResult);
        }

        public async Task EditAsync(PacienteViewModel obj)
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