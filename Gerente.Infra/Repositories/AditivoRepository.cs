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
    public class AditivoRepository : IAditivoRepository
    {
        private readonly DataDbContext _db;

        public AditivoRepository(DataDbContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Aditivo>> GetAsync()
        {
            return await _db.Aditivos.Where(p => p.Ativo).ToListAsync();
        }

        public async Task<Aditivo> GetAsync(int? id)
        {
            return await _db.Aditivos.FindAsync(id);
        }

        public async Task<Aditivo> AddAsync(Aditivo obj)
        {
            _db.Add(obj);
            await _db.SaveChangesAsync();
            return obj;
        }

        public async Task EditAsync(Aditivo obj)
        {
            _db.Update(obj);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteAsync(Aditivo obj)
        {
            obj.Ativo = false;
            _db.Update(obj);
            await _db.SaveChangesAsync();
        }
    }
}