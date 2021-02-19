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
    public class FilaProcedimentoRepository : IFilaProcedimentoRepository
    {
        private readonly DataDbContext _db;

        public FilaProcedimentoRepository(DataDbContext db)
        {
            _db = db;
        }
        public async Task<IEnumerable<FilaProcedimento>> GetAsync()
        {
            return await _db.FilaProcedimentos.Where(p => p.Ativo).ToListAsync();
        }

        public async Task<FilaProcedimento> GetAsync(int? id)
        {
            return await _db.FilaProcedimentos.FindAsync(id);
        }

        public async Task<FilaProcedimento> AddAsync(FilaProcedimento obj)
        {
            _db.Add(obj);
            await _db.SaveChangesAsync();
            return obj;
        }

        public async Task EditAsync(FilaProcedimento obj)
        {
            _db.Update(obj);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteAsync(FilaProcedimento obj)
        {
            obj.Ativo = false;
            _db.Update(obj);
            await _db.SaveChangesAsync();
        }
    }
}