using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Domain.Entities;
using Gerente.Domain.Interfaces;
using Gerente.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Gerente.Infra.Data.Repositories
{
    public class CargoRepository : ICargoRepository
    {
        private readonly DataDbContext _db;

        public CargoRepository(DataDbContext db)
        {
            _db = db;
        }
        public async Task<IEnumerable<Cargo>> Get()
        {
            return await _db.Cargos.ToListAsync();
        }

        public async Task<Cargo> Get(int? id)
        {
            return await _db.Cargos.FindAsync(id);
        }

        public void Add(Cargo obj)
        {
            _db.Add(obj);
            _db.SaveChanges();
        }

        public void Edit(Cargo obj)
        {
            _db.Update(obj);
            _db.SaveChanges();
        }

        public void Delete(Cargo obj)
        {
            obj.Ativo = false;
            _db.Update(obj);
            _db.SaveChanges();
        }
    }
}