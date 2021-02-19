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
        public async Task<IEnumerable<DocumentoAcompanhanteViewModel>> GetAsync()
        {
            var lista = await _service.GetAsync();
            return _mapper.Map<IEnumerable<DocumentoAcompanhanteViewModel>>(lista);
        }

        public async Task<DocumentoAcompanhanteViewModel> GetAsync(int? id)
        {
            var obj = await _service.GetAsync(id);
            return _mapper.Map<DocumentoAcompanhanteViewModel>(obj);
        }

        public async Task<DocumentoAcompanhanteViewModel> AddAsync(DocumentoAcompanhanteViewModel obj)
        {
            var objeto = _mapper.Map<Documento>(obj);
            var objetoResult = await _service.AddAsync(objeto);
            return _mapper.Map<DocumentoAcompanhanteViewModel>(objetoResult);
        }

        public async Task EditAsync(DocumentoAcompanhanteViewModel obj)
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