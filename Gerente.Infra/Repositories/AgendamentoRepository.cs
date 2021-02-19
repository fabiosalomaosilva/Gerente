using System.Collections.Generic;
using System.Linq;
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

        public async Task<IEnumerable<Agendamento>> GetAsync()
        {
            return await _db.Agendamentos.Where(p => p.Ativo).ToListAsync();
        }

        public async Task<Agendamento> GetAsync(int? id)
        {
            return await _db.Agendamentos.FindAsync(id);
        }

        public async Task<Agendamento> AddAsync(Agendamento obj)
        {
            _db.Add(obj);
            await _db.SaveChangesAsync();
            return obj;
        }

        public async Task EditAsync(Agendamento obj)
        {
            _db.Update(obj);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteAsync(Agendamento obj)
        {
            obj.Ativo = false;
            _db.Update(obj);
            await _db.SaveChangesAsync();
        }
    }
}