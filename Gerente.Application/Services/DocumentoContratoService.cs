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
        public async Task<IEnumerable<DocumentoContratoViewModel>> GetAsync()
        {
            var lista = await _service.GetAsync();
            return _mapper.Map<IEnumerable<DocumentoContratoViewModel>>(lista);
        }

        public async Task<DocumentoContratoViewModel> GetAsync(int? id)
        {
            var obj = await _service.GetAsync(id);
            return _mapper.Map<DocumentoContratoViewModel>(obj);
        }

        public async Task<DocumentoContratoViewModel> AddAsync(DocumentoContratoViewModel obj)
        {
            var objeto = _mapper.Map<Documento>(obj);
            var objetoResult = await _service.AddAsync(objeto);
            return _mapper.Map<DocumentoContratoViewModel>(objetoResult);
        }

        public async Task EditAsync(DocumentoContratoViewModel obj)
        {
            var objeto = _mapper.Map<Documento>(obj);
            await _service.EditAsync(objeto);
        }

        public async Task DeleteAsync(int id)
        {
            var obj = await _service.GetAsync(id);
            await _service.DeleteAsync(obj);
        }
    }
}