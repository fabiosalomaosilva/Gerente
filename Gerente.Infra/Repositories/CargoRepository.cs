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
    public class CargoRepository : ICargoRepository
    {
        private readonly DataDbContext _db;

        public CargoRepository(DataDbContext db)
        {
            _db = db;
        }
        public async Task<IEnumerable<Cargo>> GetAsync()
        {
            return await _db.Cargos.Where(p => p.Ativo).ToListAsync();
        }

        public async Task<Cargo> GetAsync(int? id)
        {
            return await _db.Cargos.FindAsync(id);
        }

        public async Task<Cargo> AddAsync(Cargo obj)
        {
            _db.Add(obj);
            await _db.SaveChangesAsync();
            return obj;
        }

        public async Task EditAsync(Cargo obj)
        {
            _db.Update(obj);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteAsync(Cargo obj)
        {
            obj.Ativo = false;
            _db.Update(obj);
            await _db.SaveChangesAsync();
        }
    }
}