using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<IEnumerable<Setor>> GetAsync()
        {
            return await _db.Setores.Where(p => p.Ativo).ToListAsync();
        }

        public async Task<Setor> GetAsync(int? id)
        {
            return await _db.Setores.FindAsync(id);
        }

        public async Task<Setor> AddAsync(Setor obj)
        {
            _db.Add(obj);
            await _db.SaveChangesAsync();
            return obj;
        }

        public async Task EditAsync(Setor obj)
        {
            _db.Update(obj);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteAsync(Setor obj)
        {
            obj.Ativo = false;
            _db.Update(obj);
            await _db.SaveChangesAsync();
        }
    }
}