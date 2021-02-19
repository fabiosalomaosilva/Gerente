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
    public class MunicipioRepository : IMunicipioRepository
    {
        private readonly DataDbContext _db;

        public MunicipioRepository(DataDbContext db)
        {
            _db = db;
        }
        public async Task<IEnumerable<Municipio>> GetAsync()
        {
            return await _db.Municipios.Where(p => p.Ativo).ToListAsync();
        }

        public async Task<Municipio> GetAsync(int? id)
        {
            return await _db.Municipios.FindAsync(id);
        }

        public async Task<Municipio> AddAsync(Municipio obj)
        {
            _db.Add(obj);
            await _db.SaveChangesAsync();
            return obj;
        }

        public async Task EditAsync(Municipio obj)
        {
            _db.Update(obj);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteAsync(Municipio obj)
        {
            obj.Ativo = false;
            _db.Update(obj);
            await _db.SaveChangesAsync();
        }
    }
}