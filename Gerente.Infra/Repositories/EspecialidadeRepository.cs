using System;
using System.Collections.Generic;
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
        public async Task<IEnumerable<Especialidade>> Get()
        {
            return await _db.Especialidades.ToListAsync();
        }

        public async Task<Especialidade> Get(int? id)
        {
            return await _db.Especialidades.FindAsync(id);
        }

        public void Add(Especialidade obj)
        {






            _db.Add(obj);
            _db.SaveChanges();
        }

        public void Edit(Especialidade obj)
        {
            obj.AlteradoEm = DateTime.Now;

            _db.Update(obj);
            _db.SaveChanges();
        }

        public void Delete(Especialidade obj)
        {
            obj.Ativo = false;
            obj.AlteradoEm = DateTime.Now;

            _db.Update(obj);
            _db.SaveChanges();
        }
    }
}