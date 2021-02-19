using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Gerente.Application.Interfaces;
using Gerente.Application.ViewModels;
using Gerente.Domain.Entities;
using Gerente.Domain.Interfaces;

namespace Gerente.Application.Services
{
    public class MedicoService : IMedicoService
    {
        private readonly IMedicoRepository _service;
        private readonly IMapper _mapper;

        public MedicoService(IMedicoRepository service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        public async Task<IEnumerable<MedicoViewModel>> GetAsync()
        {
            var lista = await _service.GetAsync();
            return _mapper.Map<IEnumerable<MedicoViewModel>>(lista);
        }

        public async Task<MedicoViewModel> GetAsync(int? id)
        {
            var obj = await _service.GetAsync(id);
            return _mapper.Map<MedicoViewModel>(obj);
        }

        public async Task<MedicoViewModel> AddAsync(MedicoViewModel obj)
        {
            var objeto = _mapper.Map<Medico>(obj);
            var objetoResult = await _service.AddAsync(objeto);
            return _mapper.Map<MedicoViewModel>(objetoResult);
        }

        public async Task EditAsync(MedicoViewModel obj)
        {
            var objeto = _mapper.Map<Medico>(obj);
            await _service.EditAsync(objeto);
        }

        public async Task DeleteAsync(int id)
        {
            var obj = await _service.GetAsync(id);
            await _service.DeleteAsync(obj);
        }
    }
}