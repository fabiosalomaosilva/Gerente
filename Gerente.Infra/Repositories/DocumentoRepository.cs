using System;
using System.Collections.Generic;
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
        public async Task<IEnumerable<Documento>> Get()
        {
            return await _db.Documentos.ToListAsync();
        }

        public async Task<Documento> Get(int? id)
        {
            return await _db.Documentos.FindAsync(id);
        }

        public void Add(Documento obj)
        {






            _db.Add(obj);
            _db.SaveChanges();
        }

        public void Edit(Documento obj)
        {
            obj.AlteradoEm = DateTime.Now;

            _db.Update(obj);
            _db.SaveChanges();
        }

        public void Delete(Documento obj)
        {
            obj.Ativo = false;
            obj.AlteradoEm = DateTime.Now;

            _db.Update(obj);
            _db.SaveChanges();
        }
    }
}