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
        public async Task<IEnumerable<AgendamentoViewModel>> Get()
        {
            var lista = await _service.Get();
            return _mapper.Map<IEnumerable<AgendamentoViewModel>>(lista);
        }

        public async Task<AgendamentoViewModel> Get(int? id)
        {
            var obj = await _service.Get(id);
            return _mapper.Map<AgendamentoViewModel>(obj);
        }

        public void Add(AgendamentoViewModel obj)
        {
            var objeto = _mapper.Map<Agendamento>(obj);
            _service.Add(objeto);
        }

        public void Edit(AgendamentoViewModel obj)
        {
            var objeto = _mapper.Map<Agendamento>(obj);
            _service.Edit(objeto);
        }

        public void Delete(int id)
        {
            var obj = _service.Get(id).Result;
            _service.Delete(obj);
        }
    }
}