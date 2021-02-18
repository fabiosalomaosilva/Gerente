using System;
using System.Collections.Generic;
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

        public async Task<IEnumerable<Secretaria>> Get()
        {
            return await _db.Secretarias.ToListAsync();
        }

        public async Task<Secretaria> Get(int? id)
        {
            return await _db.Secretarias.FindAsync(id);
        }

        public void Add(Secretaria obj)
        {






            _db.Add(obj);
            _db.SaveChanges();
        }

        public void Edit(Secretaria obj)
        {
            obj.AlteradoEm = DateTime.Now;

            _db.Update(obj);
            _db.SaveChanges();
        }

        public void Delete(Secretaria obj)
        {
            obj.Ativo = false;
            obj.AlteradoEm = DateTime.Now;

            _db.Update(obj);
            _db.SaveChanges();
        }
    }
}