using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Domain.Entities;
using Gerente.Domain.Interfaces;
using Gerente.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Gerente.Infra.Data.Repositories
{
    public class FilaProcedimentoRepository : IFilaProcedimentoRepository
    {
        private readonly DataDbContext _db;

        public FilaProcedimentoRepository(DataDbContext db)
        {
            _db = db;
        }
        public async Task<IEnumerable<FilaProcedimento>> Get()
        {
            return await _db.FilaProcedimentos.ToListAsync();
        }

        public async Task<FilaProcedimento> Get(int? id)
        {
            return await _db.FilaProcedimentos.FindAsync(id);
        }

        public void Add(FilaProcedimento obj)
        {






            _db.Add(obj);
            _db.SaveChanges();
        }

        public void Edit(FilaProcedimento obj)
        {
            obj.AlteradoEm = DateTime.Now;

            _db.Update(obj);
            _db.SaveChanges();
        }

        public void Delete(FilaProcedimento obj)
        {
            obj.Ativo = false;
            obj.AlteradoEm = DateTime.Now;

            _db.Update(obj);
            _db.SaveChanges();
        }
    }
}