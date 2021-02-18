using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Domain.Entities;
using Gerente.Domain.Interfaces;
using Gerente.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Gerente.Infra.Data.Repositories
{
    public class ProcedimentoRepository : IProcedimentoRepository
    {
        private readonly DataDbContext _db;

        public ProcedimentoRepository(DataDbContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Procedimento>> Get()
        {
            return await _db.Procedimentos.ToListAsync();
        }

        public async Task<Procedimento> Get(int? id)
        {
            return await _db.Procedimentos.FindAsync(id);
        }

        public void Add(Procedimento obj)
        {






            _db.Add(obj);
            _db.SaveChanges();
        }

        public void Edit(Procedimento obj)
        {
            obj.AlteradoEm = DateTime.Now;

            _db.Update(obj);
            _db.SaveChanges();
        }

        public void Delete(Procedimento obj)
        {
            obj.Ativo = false;
            obj.AlteradoEm = DateTime.Now;

            _db.Update(obj);
            _db.SaveChanges();
        }
    }
}