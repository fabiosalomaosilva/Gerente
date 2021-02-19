using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Domain.Entities;
using Gerente.Domain.Interfaces;
using Gerente.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Gerente.Infra.Data.Repositories
{
    public class ContratoRepository : IContratoRepository
    {
        private readonly DataDbContext _db;

        public ContratoRepository(DataDbContext db)
        {
            _db = db;
        }
        public async Task<IEnumerable<Contrato>> GetAsync()
        {
            return await _db.Contratos.ToListAsync();
        }

        public async Task<Contrato> GetAsync(int? id)
        {
            return await _db.Contratos.FindAsync(id);
        }

        public async Task<Contrato> AddAsync(Contrato obj)
        {
            _db.Add(obj);
            await _db.SaveChangesAsync();
            return obj;
        }

        public async Task EditAsync(Contrato obj)
        {
            _db.Update(obj);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteAsync(Contrato obj)
        {
            obj.Ativo = false;
            _db.Update(obj);
            await _db.SaveChangesAsync();
        }
    }
}