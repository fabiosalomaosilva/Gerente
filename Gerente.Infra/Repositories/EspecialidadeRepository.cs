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
    public class EspecialidadeRepository : IEspecialidadeRepository
    {
        private readonly DataDbContext _db;

        public EspecialidadeRepository(DataDbContext db)
        {
            _db = db;
        }
        public async Task<IEnumerable<Especialidade>> GetAsync()
        {
            return await _db.Especialidades.Where(p => p.Ativo).ToListAsync();
        }

        public async Task<Especialidade> GetAsync(int? id)
        {
            return await _db.Especialidades.FindAsync(id);
        }

        public async Task<Especialidade> AddAsync(Especialidade obj)
        {
            _db.Add(obj);
            await _db.SaveChangesAsync();
            return obj;
        }

        public async Task EditAsync(Especialidade obj)
        {
            _db.Update(obj);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteAsync(Especialidade obj)
        {
            obj.Ativo = false;
            _db.Update(obj);
            await _db.SaveChangesAsync();
        }
    }
}