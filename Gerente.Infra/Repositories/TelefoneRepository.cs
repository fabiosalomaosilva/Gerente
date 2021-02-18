using System;
using System.Collections.Generic;
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

        public async Task<IEnumerable<Telefone>> Get()
        {
            return await _db.Telefones.ToListAsync();
        }

        public async Task<Telefone> Get(int? id)
        {
            return await _db.Telefones.FindAsync(id);
        }

        public void Add(Telefone obj)
        {






            _db.Add(obj);
            _db.SaveChanges();
        }

        public void Edit(Telefone obj)
        {
            obj.AlteradoEm = DateTime.Now;

            _db.Update(obj);
            _db.SaveChanges();
        }

        public void Delete(Telefone obj)
        {
            obj.Ativo = false;
            obj.AlteradoEm = DateTime.Now;

            _db.Update(obj);
            _db.SaveChanges();
        }
    }
}