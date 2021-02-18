using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Gerente.Application.Interfaces;
using Gerente.Application.ViewModels;
using Gerente.Domain.Entities;
using Gerente.Domain.Interfaces;

namespace Gerente.Application.Services
{
    public class TelefoneService : ITelefoneService
    {
        private readonly ITelefoneRepository _service;
        private readonly IMapper _mapper;

        public TelefoneService(ITelefoneRepository service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        public async Task<IEnumerable<TelefoneViewModel>> Get()
        {
            var lista = await _service.Get();
            return _mapper.Map<IEnumerable<TelefoneViewModel>>(lista);
        }

        public async Task<TelefoneViewModel> Get(int? id)
        {
            var obj = await _service.Get(id);
            return _mapper.Map<TelefoneViewModel>(obj);
        }

        public void Add(TelefoneViewModel obj)
        {
            var objeto = _mapper.Map<Telefone>(obj);
            _service.Add(objeto);
        }

        public void Edit(TelefoneViewModel obj)
        {
            var objeto = _mapper.Map<Telefone>(obj);
            _service.Edit(objeto);
        }

        public void Delete(int id)
        {
            var obj = _service.Get(id).Result;
            _service.Delete(obj);
        }
    }
}