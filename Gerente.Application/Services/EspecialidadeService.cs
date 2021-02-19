using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Gerente.Application.Interfaces;
using Gerente.Application.ViewModels;
using Gerente.Domain.Entities;
using Gerente.Domain.Interfaces;

namespace Gerente.Application.Services
{
    public class EspecialidadeService : IEspecialidadeService
    {
        private readonly IEspecialidadeRepository _service;
        private readonly IMapper _mapper;

        public EspecialidadeService(IEspecialidadeRepository service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        public async Task<IEnumerable<EspecialidadeViewModel>> GetAsync()
        {
            var lista = await _service.GetAsync();
            return _mapper.Map<IEnumerable<EspecialidadeViewModel>>(lista);
        }

        public async Task<EspecialidadeViewModel> GetAsync(int? id)
        {
            var obj = await _service.GetAsync(id);
            return _mapper.Map<EspecialidadeViewModel>(obj);
        }

        public async Task<EspecialidadeViewModel> AddAsync(EspecialidadeViewModel obj)
        {
            var objeto = _mapper.Map<Especialidade>(obj);
            var objetoResult = await _service.AddAsync(objeto);
            return _mapper.Map<EspecialidadeViewModel>(objetoResult);
        }

        public async Task EditAsync(EspecialidadeViewModel obj)
        {
            var objeto = _mapper.Map<Especialidade>(obj);
            await _service.EditAsync(objeto);
        }

        public async Task DeleteAsync(int id)
        {
            var obj = await _service.GetAsync(id);
            await _service.DeleteAsync(obj);
        }
    }
}