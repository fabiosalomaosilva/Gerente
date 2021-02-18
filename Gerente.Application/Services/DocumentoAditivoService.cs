using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Gerente.Application.Interfaces;
using Gerente.Application.ViewModels;
using Gerente.Domain.Entities;
using Gerente.Domain.Interfaces;

namespace Gerente.Application.Services
{
    public class DocumentoAditivoService : IDocumentoAditivoService
    {
        private readonly IDocumentoRepository _service;
        private readonly IMapper _mapper;

        public DocumentoAditivoService(IDocumentoRepository service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        public async Task<IEnumerable<DocumentoAditivoViewModel>> Get()
        {
            var lista = await _service.Get();
            return _mapper.Map<IEnumerable<DocumentoAditivoViewModel>>(lista);
        }

        public async Task<DocumentoAditivoViewModel> Get(int? id)
        {
            var obj = await _service.Get(id);
            return _mapper.Map<DocumentoAditivoViewModel>(obj);
        }

        public void Add(DocumentoAditivoViewModel obj)
        {
            var objeto = _mapper.Map<Documento>(obj);
            _service.Add(objeto);
        }

        public void Edit(DocumentoAditivoViewModel obj)
        {
            var objeto = _mapper.Map<Documento>(obj);
            _service.Edit(objeto);
        }

        public void Delete(int id)
        {
            var obj = _service.Get(id).Result;
            _service.Delete(obj);
        }
    }
}