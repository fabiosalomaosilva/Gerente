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
        public async Task<IEnumerable<MedicoViewModel>> Get()
        {
            var lista = await _service.Get();
            return _mapper.Map<IEnumerable<MedicoViewModel>>(lista);
        }

        public async Task<MedicoViewModel> Get(int? id)
        {
            var obj = await _service.Get(id);
            return _mapper.Map<MedicoViewModel>(obj);
        }

        public void Add(MedicoViewModel obj, string nomeUsuario)
        {
            var objeto = _mapper.Map<Medico>(obj);
            _service.Add(objeto, nomeUsuario);
        }

        public void Edit(MedicoViewModel obj, string nomeUsuario)
        {
            var objeto = _mapper.Map<Medico>(obj);
            _service.Edit(objeto, nomeUsuario);
        }

        public void Delete(int id, string nomeUsuario)
        {
            var obj = _service.Get(id).Result;
            _service.Delete(obj, nomeUsuario);
        }
    }
}