using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Domain.Entities;
using Gerente.Domain.Interfaces;
using Gerente.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Gerente.Infra.Data.Repositories
{
    public class SetorRepository : ISetorRepository
    {
        private readonly DataDbContext _db;

        public SetorRepository(DataDbContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Setor>> Get()
        {
            return await _db.Setores.ToListAsync();
        }

        public async Task<Setor> Get(int? id)
        {
            return await _db.Setores.FindAsync(id);
        }

        public void Add(Setor obj)
        {






            _db.Add(obj);
            _db.SaveChanges();
        }

        public void Edit(Setor obj)
        {
            obj.AlteradoEm = DateTime.Now;

            _db.Update(obj);
            _db.SaveChanges();
        }

        public void Delete(Setor obj)
        {
            obj.Ativo = false;
            obj.AlteradoEm = DateTime.Now;

            _db.Update(obj);
            _db.SaveChanges();
        }
    }
}