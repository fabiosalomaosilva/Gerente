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
    public class PessoaRepository : IPessoaRepository
    {
        private readonly DataDbContext _db;

        public PessoaRepository(DataDbContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Pessoa>> GetAsync()
        {
            return await _db.Pessoas.Where(p => p.Ativo).ToListAsync();
        }

        public async Task<Pessoa> GetAsync(int? id)
        {
            return await _db.Pessoas.FindAsync(id);
        }

        public async Task<Pessoa> AddAsync(Pessoa obj)
        {
            _db.Add(obj);
            await _db.SaveChangesAsync();
            return obj;
        }

        public async Task EditAsync(Pessoa obj)
        {
            _db.Update(obj);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteAsync(Pessoa obj)
        {
            obj.Ativo = false;
            _db.Update(obj);
            await _db.SaveChangesAsync();
        }
    }
}