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

        public void Add(Agendamento obj, string nomeUsuario)
        {
            var data = DateTime.Now;
            obj.AlteradoEm = data;
            obj.CriadoEm = data;
            obj.AlteradoPor = nomeUsuario;
            obj.CriadoPor = nomeUsuario;
            obj.Ativo = true;
            _db.Add(obj);
            _db.SaveChanges();
        }

        public void Edit(Agendamento obj, string nomeUsuario)
        {
            obj.AlteradoEm = DateTime.Now;
            obj.AlteradoPor = nomeUsuario;
            _db.Update(obj);
            _db.SaveChanges();
        }

        public void Delete(Agendamento obj, string nomeUsuario)
        {
            obj.Ativo = false;
            obj.AlteradoEm = DateTime.Now;
            obj.AlteradoPor = nomeUsuario;
            _db.Update(obj);
            _db.SaveChanges();
        }
    }
}