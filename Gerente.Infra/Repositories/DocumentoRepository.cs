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
    public class DocumentoRepository : IDocumentoRepository
    {
        private readonly DataDbContext _db;

        public DocumentoRepository(DataDbContext db)
        {
            _db = db;
        }
        public async Task<IEnumerable<Documento>> GetAsync()
        {
            return await _db.Documentos.Where(p => p.Ativo).ToListAsync();
        }

        public async Task<Documento> GetAsync(int? id)
        {
            return await _db.Documentos.FindAsync(id);
        }

        public async Task<Documento> AddAsync(Documento obj)
        {
            _db.Add(obj);
            await _db.SaveChangesAsync();
            return obj;
        }

        public async Task EditAsync(Documento obj)
        {
            _db.Update(obj);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteAsync(Documento obj)
        {
            obj.Ativo = false;
            _db.Update(obj);
            await _db.SaveChangesAsync();
        }
    }
}