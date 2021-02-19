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
    public class MedicoRepository : IMedicoRepository
    {
        private readonly DataDbContext _db;

        public MedicoRepository(DataDbContext db)
        {
            _db = db;
        }
        public async Task<IEnumerable<Medico>> GetAsync()
        {
            return await _db.Medicos.Where(p => p.Ativo).ToListAsync();
        }

        public async Task<Medico> GetAsync(int? id)
        {
            return await _db.Medicos.FindAsync(id);
        }

        public async Task<Medico> AddAsync(Medico obj)
        {
            _db.Add(obj);
            await _db.SaveChangesAsync();
            return obj;
        }

        public async Task EditAsync(Medico obj)
        {
            obj.AlteradoEm = DateTime.Now;

            _db.Update(obj);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteAsync(Medico obj)
        {
            obj.Ativo = false;
            _db.Update(obj);
            await _db.SaveChangesAsync();
        }
    }
}