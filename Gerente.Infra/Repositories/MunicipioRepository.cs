using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Domain.Entities;
using Gerente.Domain.Interfaces;
using Gerente.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Gerente.Infra.Data.Repositories
{
    public class MunicipioRepository : IMunicipioRepository
    {
        private readonly DataDbContext _db;

        public MunicipioRepository(DataDbContext db)
        {
            _db = db;
        }
        public async Task<IEnumerable<Municipio>> Get()
        {
            return await _db.Municipios.ToListAsync();
        }

        public async Task<Municipio> Get(int? id)
        {
            return await _db.Municipios.FindAsync(id);
        }

        public void Add(Municipio obj)
        {






            _db.Add(obj);
            _db.SaveChanges();
        }

        public void Edit(Municipio obj)
        {
            obj.AlteradoEm = DateTime.Now;

            _db.Update(obj);
            _db.SaveChanges();
        }

        public void Delete(Municipio obj)
        {
            obj.Ativo = false;
            obj.AlteradoEm = DateTime.Now;

            _db.Update(obj);
            _db.SaveChanges();
        }
    }
}