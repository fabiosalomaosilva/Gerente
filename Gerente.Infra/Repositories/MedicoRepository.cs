using System;
using System.Collections.Generic;
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
        public async Task<IEnumerable<Medico>> Get()
        {
            return await _db.Medicos.ToListAsync();
        }

        public async Task<Medico> Get(int? id)
        {
            return await _db.Medicos.FindAsync(id);
        }

        public void Add(Medico obj)
        {






            _db.Add(obj);
            _db.SaveChanges();
        }

        public void Edit(Medico obj)
        {
            obj.AlteradoEm = DateTime.Now;

            _db.Update(obj);
            _db.SaveChanges();
        }

        public void Delete(Medico obj)
        {
            obj.Ativo = false;
            obj.AlteradoEm = DateTime.Now;

            _db.Update(obj);
            _db.SaveChanges();
        }
    }
}