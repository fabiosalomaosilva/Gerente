using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Gerente.Application.Interfaces;
using Gerente.Application.ViewModels;
using Gerente.Domain.Entities;
using Gerente.Domain.Interfaces;

namespace Gerente.Application.Services
{
    public class DocumentoAcompanhanteService : IDocumentoAcompanhanteService
    {
        private readonly IDocumentoRepository _service;
        private readonly IMapper _mapper;

        public DocumentoAcompanhanteService(IDocumentoRepository service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        public async Task<IEnumerable<DocumentoAcompanhanteViewModel>> Get()
        {
            var lista = await _service.Get();
            return _mapper.Map<IEnumerable<DocumentoAcompanhanteViewModel>>(lista);
        }

        public async Task<DocumentoAcompanhanteViewModel> Get(int? id)
        {
            var obj = await _service.Get(id);
            return _mapper.Map<DocumentoAcompanhanteViewModel>(obj);
        }

        public void Add(DocumentoAcompanhanteViewModel obj)
        {
            var objeto = _mapper.Map<Documento>(obj);
            _service.Add(objeto);
        }

        public void Edit(DocumentoAcompanhanteViewModel obj)
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