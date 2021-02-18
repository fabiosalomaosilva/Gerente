using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Domain.Entities;
using Gerente.Domain.Interfaces;
using Gerente.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Gerente.Infra.Data.Repositories
{
    public class ContratoRepository : IContratoRepository
    {
        private readonly DataDbContext _db;

        public ContratoRepository(DataDbContext db)
        {
            _db = db;
        }
        public async Task<IEnumerable<Contrato>> Get()
        {
            return await _db.Contratos.ToListAsync();
        }

        public async Task<Contrato> Get(int? id)
        {
            return await _db.Contratos.FindAsync(id);
        }

        public void Add(Contrato obj)
        {






            _db.Add(obj);
            _db.SaveChanges();
        }

        public void Edit(Contrato obj)
        {
            obj.AlteradoEm = DateTime.Now;

            _db.Update(obj);
            _db.SaveChanges();
        }

        public void Delete(Contrato obj)
        {
            obj.Ativo = false;
            obj.AlteradoEm = DateTime.Now;

            _db.Update(obj);
            _db.SaveChanges();
        }
    }
}