using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Gerente.Application.Interfaces;
using Gerente.Application.ViewModels;
using Gerente.Domain.Entities;
using Gerente.Domain.Interfaces;

namespace Gerente.Application.Services
{
    public class AgendamentoService : IAgendamentoService
    {
        private readonly IAgendamentoRepository _service;
        private readonly IMapper _mapper;

        public AgendamentoService(IAgendamentoRepository service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        public async Task<IEnumerable<AgendamentoViewModel>> GetAsync()
        {
            var lista = await _service.GetAsync();
            return _mapper.Map<IEnumerable<AgendamentoViewModel>>(lista);
        }

        public async Task<AgendamentoViewModel> GetAsync(int? id)
        {
            var obj = await _service.GetAsync(id);
            return _mapper.Map<AgendamentoViewModel>(obj);
        }

        public async Task<AgendamentoViewModel> AddAsync(AgendamentoViewModel obj)
        {
            var objeto = _mapper.Map<Agendamento>(obj);
            var objetoResult = await _service.AddAsync(objeto);
            return _mapper.Map<AgendamentoViewModel>(objetoResult);
        }

        public async Task EditAsync(AgendamentoViewModel obj)
        {
            var objeto = _mapper.Map<Agendamento>(obj);
            await _service.EditAsync(objeto);
        }

        public async Task DeleteAsync(int id)
        {
            var obj = await _service.GetAsync(id);
            await _service.DeleteAsync(obj);
        }
    }
}