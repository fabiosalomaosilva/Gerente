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
    public class TelefoneRepository : ITelefoneRepository
    {
        private readonly DataDbContext _db;

        public TelefoneRepository(DataDbContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Telefone>> GetAsync()
        {
            return await _db.Telefones.Where(p => p.Ativo).ToListAsync();
        }

        public async Task<Telefone> GetAsync(int? id)
        {
            return await _db.Telefones.FindAsync(id);
        }

        public async Task<Telefone> AddAsync(Telefone obj)
        {
            _db.Add(obj);
            await _db.SaveChangesAsync();
            return obj;
        }

        public async Task EditAsync(Telefone obj)
        {
            _db.Update(obj);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteAsync(Telefone obj)
        {
            obj.Ativo = false;
            _db.Update(obj);
            await _db.SaveChangesAsync();
        }
    }
}