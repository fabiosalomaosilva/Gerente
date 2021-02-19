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
    public class LocalProcedimentoRepository : ILocalProcedimentoRepository
    {
        private readonly DataDbContext _db;

        public LocalProcedimentoRepository(DataDbContext db)
        {
            _db = db;
        }
        public async Task<IEnumerable<LocalProcedimento>> GetAsync()
        {
            return await _db.LocalProcedimentos.Where(p => p.Ativo).ToListAsync();
        }

        public async Task<LocalProcedimento> GetAsync(int? id)
        {
            return await _db.LocalProcedimentos.FindAsync(id);
        }

        public async Task<LocalProcedimento> AddAsync(LocalProcedimento obj)
        {
            _db.Add(obj);
            await _db.SaveChangesAsync();
            return obj;
        }

        public async Task EditAsync(LocalProcedimento obj)
        {
            _db.Update(obj);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteAsync(LocalProcedimento obj)
        {
            obj.Ativo = false;
            _db.Update(obj);
            await _db.SaveChangesAsync();
        }
    }
}