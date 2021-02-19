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
    public class ProcedimentoRepository : IProcedimentoRepository
    {
        private readonly DataDbContext _db;

        public ProcedimentoRepository(DataDbContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Procedimento>> GetAsync()
        {
            return await _db.Procedimentos.Where(p => p.Ativo).ToListAsync();
        }

        public async Task<Procedimento> GetAsync(int? id)
        {
            return await _db.Procedimentos.FindAsync(id);
        }

        public async Task<Procedimento> AddAsync(Procedimento obj)
        {
            _db.Add(obj);
            await _db.SaveChangesAsync();
            return obj;
        }

        public async Task EditAsync(Procedimento obj)
        {
            _db.Update(obj);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteAsync(Procedimento obj)
        {
            obj.Ativo = false;
            _db.Update(obj);
            await _db.SaveChangesAsync();
        }
    }
}