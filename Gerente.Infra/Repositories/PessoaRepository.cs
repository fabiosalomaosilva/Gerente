using System;
using System.Collections.Generic;
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

        public async Task<IEnumerable<Pessoa>> Get()
        {
            return await _db.Pessoas.ToListAsync();
        }

        public async Task<Pessoa> Get(int? id)
        {
            return await _db.Pessoas.FindAsync(id);
        }

        public void Add(Pessoa obj)
        {






            _db.Add(obj);
            _db.SaveChanges();
        }

        public void Edit(Pessoa obj)
        {
            obj.AlteradoEm = DateTime.Now;

            _db.Update(obj);
            _db.SaveChanges();
        }

        public void Delete(Pessoa obj)
        {
            obj.Ativo = false;
            obj.AlteradoEm = DateTime.Now;

            _db.Update(obj);
            _db.SaveChanges();
        }
    }
}