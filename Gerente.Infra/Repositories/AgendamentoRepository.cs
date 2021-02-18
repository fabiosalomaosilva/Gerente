using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Domain.Entities;
using Gerente.Domain.Interfaces;
using Gerente.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Gerente.Infra.Data.Repositories
{
    public class AgendamentoRepository : IAgendamentoRepository
    {
        private readonly DataDbContext _db;

        public AgendamentoRepository(DataDbContext db)
        {
            _db = db;
        }
        public async Task<IEnumerable<Agendamento>> Get()
        {
            return await _db.Agendamentos.ToListAsync();
        }

        public async Task<Agendamento> Get(int? id)
        {
            return await _db.Agendamentos.FindAsync(id);
        }

        public void Add(Agendamento obj)
        {
            _db.Add(obj);
            _db.SaveChanges();
        }

        public void Edit(Agendamento obj)
        {
            _db.Update(obj);
            _db.SaveChanges();
        }

        public void Delete(Agendamento obj)
        {
            obj.Ativo = false;
            _db.Update(obj);
            _db.SaveChanges();
        }
    }
}