using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Gerente.Application.Interfaces;
using Gerente.Application.ViewModels;
using Gerente.Domain.Entities;
using Gerente.Domain.Interfaces;

namespace Gerente.Application.Services
{
    public class DocumentoContratoService : IDocumentoContratoService
    {
        private readonly IDocumentoRepository _service;
        private readonly IMapper _mapper;

        public DocumentoContratoService(IDocumentoRepository service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        public async Task<IEnumerable<DocumentoContratoViewModel>> Get()
        {
            var lista = await _service.Get();
            return _mapper.Map<IEnumerable<DocumentoContratoViewModel>>(lista);
        }

        public async Task<DocumentoContratoViewModel> Get(int? id)
        {
            var obj = await _service.Get(id);
            return _mapper.Map<DocumentoContratoViewModel>(obj);
        }

        public void Add(DocumentoContratoViewModel obj)
        {
            var objeto = _mapper.Map<Documento>(obj);
            _service.Add(objeto);
        }

        public void Edit(DocumentoContratoViewModel obj)
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