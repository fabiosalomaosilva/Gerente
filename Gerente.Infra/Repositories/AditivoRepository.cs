﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gerente.Domain.Entities;
using Gerente.Domain.Interfaces;
using Gerente.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Gerente.Infra.Data.Repositories
{
    class AditivoRepository : IAditivoRepository
    {
        private readonly DataDbContext _db;

        public AditivoRepository(DataDbContext db)
        {
            _db = db;
        }
        public async Task<IEnumerable<Aditivo>> Get()
        {
            return await _db.Aditivos.ToListAsync();
        }

        public async Task<Aditivo> Get(int? id)
        {
            return await _db.Aditivos.FindAsync(id);
        }

        public void Add(Aditivo obj)
        {
            _db.Add(obj);
            _db.SaveChanges();
        }

        public void Edit(Aditivo obj)
        {
            _db.Update(obj);
            _db.SaveChanges();
        }

        public void Delete(Aditivo obj)
        {
            obj.Ativo = false;
            _db.Update(obj);
            _db.SaveChanges();
        }
    }
}
