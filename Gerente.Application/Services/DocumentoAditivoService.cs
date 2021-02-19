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
        public async Task<IEnumerable<DocumentoAditivoViewModel>> GetAsync()
        {
            var lista = await _service.GetAsync();
            return _mapper.Map<IEnumerable<DocumentoAditivoViewModel>>(lista);
        }

        public async Task<DocumentoAditivoViewModel> GetAsync(int? id)
        {
            var obj = await _service.GetAsync(id);
            return _mapper.Map<DocumentoAditivoViewModel>(obj);
        }

        public async Task<DocumentoAditivoViewModel> AddAsync(DocumentoAditivoViewModel obj)
        {
            var objeto = _mapper.Map<Documento>(obj);
            var objetoResult = await _service.AddAsync(objeto);
            return _mapper.Map<DocumentoAditivoViewModel>(objetoResult);
        }

        public async Task EditAsync(DocumentoAditivoViewModel obj)
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