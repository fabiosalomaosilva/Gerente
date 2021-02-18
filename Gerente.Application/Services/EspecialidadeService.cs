﻿using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Gerente.Application.Interfaces;
using Gerente.Application.ViewModels;
using Gerente.Domain.Entities;
using Gerente.Domain.Interfaces;

namespace Gerente.Application.Services
{
    public class EspecialidadeService : IEspecialidadeService
    {
        private readonly IEspecialidadeRepository _service;
        private readonly IMapper _mapper;

        public EspecialidadeService(IEspecialidadeRepository service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        public async Task<IEnumerable<EspecialidadeViewModel>> Get()
        {
            var lista = await _service.Get();
            return _mapper.Map<IEnumerable<EspecialidadeViewModel>>(lista);
        }

        public async Task<EspecialidadeViewModel> Get(int? id)
        {
            var obj = await _service.Get(id);
            return _mapper.Map<EspecialidadeViewModel>(obj);
        }

        public void Add(EspecialidadeViewModel obj)
        {
            var objeto = _mapper.Map<Especialidade>(obj);
            _service.Add(objeto);
        }

        public void Edit(EspecialidadeViewModel obj)
        {
            var objeto = _mapper.Map<Especialidade>(obj);
            _service.Edit(objeto);
        }

        public void Delete(int id)
        {
            var obj = _service.Get(id).Result;
            _service.Delete(obj);
        }
    }
}