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
    public class SecretariaRepository : ISecretariaRepository
    {
        private readonly DataDbContext _db;

        public SecretariaRepository(DataDbContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Secretaria>> GetAsync()
        {
            return await _db.Secretarias.Where(p => p.Ativo).ToListAsync();
        }

        public async Task<Secretaria> GetAsync(int? id)
        {
            return await _db.Secretarias.FindAsync(id);
        }

        public async Task<Secretaria> AddAsync(Secretaria obj)
        {
            _db.Add(obj);
            await _db.SaveChangesAsync();
            return obj;
        }

        public async Task EditAsync(Secretaria obj)
        {
            _db.Update(obj);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteAsync(Secretaria obj)
        {
            obj.Ativo = false;
            _db.Update(obj);
            await _db.SaveChangesAsync();
        }
    }
}