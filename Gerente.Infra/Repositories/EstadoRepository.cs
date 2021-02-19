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
    public class EstadoRepository : IEstadoRepository
    {
        private readonly DataDbContext _db;

        public EstadoRepository(DataDbContext db)
        {
            _db = db;
        }
        public async Task<IEnumerable<Estado>> GetAsync()
        {
            return await _db.Estados.Where(p => p.Ativo).ToListAsync();
        }

        public async Task<Estado> GetAsync(int? id)
        {
            return await _db.Estados.FindAsync(id);
        }

        public async Task<Estado> AddAsync(Estado obj)
        {
            _db.Add(obj);
            await _db.SaveChangesAsync();
            return obj;
        }

        public async Task EditAsync(Estado obj)
        {
            obj.Ativo = true;
            _db.Update(obj);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteAsync(Estado obj)
        {
            obj.Ativo = false;
            _db.Update(obj);
            await _db.SaveChangesAsync();
        }
    }
}