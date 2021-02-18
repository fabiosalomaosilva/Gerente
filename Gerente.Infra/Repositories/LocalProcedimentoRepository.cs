using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Domain.Entities;
using Gerente.Domain.Interfaces;
using Gerente.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Gerente.Infra.Data.Repositories
{
    public class LocalProcedimentoRepository : ILocalProcedimentoRepository
    {
        private readonly DataDbContext _db;

        public LocalProcedimentoRepository(DataDbContext db)
        {
            _db = db;
        }
        public async Task<IEnumerable<LocalProcedimento>> Get()
        {
            return await _db.LocalProcedimentos.ToListAsync();
        }

        public async Task<LocalProcedimento> Get(int? id)
        {
            return await _db.LocalProcedimentos.FindAsync(id);
        }

        public void Add(LocalProcedimento obj)
        {






            _db.Add(obj);
            _db.SaveChanges();
        }

        public void Edit(LocalProcedimento obj)
        {
            obj.AlteradoEm = DateTime.Now;

            _db.Update(obj);
            _db.SaveChanges();
        }

        public void Delete(LocalProcedimento obj)
        {
            obj.Ativo = false;
            obj.AlteradoEm = DateTime.Now;

            _db.Update(obj);
            _db.SaveChanges();
        }
    }
}