using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gerente.Domain.Entities;
using Gerente.Domain.Interfaces;
using Gerente.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Primitives;

namespace Gerente.Infra.Data.Repositories
{
    public class EstadoRepository : IEstadoRepository
    {
        private readonly DataDbContext _db;

        public EstadoRepository(DataDbContext db)
        {
            _db = db;
        }
        public async Task<ListData> GetAsync(PaginationDTO pagination, string name = null)
        {
            var lista = _db.Estados.Where(p => p.Ativo).AsQueryable();
            var count = lista.Count();
            var filter = string.Empty;
            var list = new List<Estado>();

            if (string.IsNullOrEmpty(filter))
            {
                list = await lista.OrderBy(p => p.Nome).Skip(pagination.Page).Take(pagination.QuantityPerPage).ToListAsync();
            }
            else
            {
                var array = name.Split(" ");
                foreach (var i in array)
                {
                    var listDoArray = lista.Where(p => p.Nome.Contains(i));
                    foreach (var s in listDoArray)
                    {
                        if (string.IsNullOrEmpty(list.FirstOrDefault(p => p.Id == s.Id)?.Id.ToString()))
                        {
                            list.Add(s);
                        }
                    }
                }

                list = list.OrderBy(p => p.Nome).Skip(pagination.Page).Take(pagination.QuantityPerPage).ToList();
            }
            var quantidadePaginas = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(count) / pagination.QuantityPerPage));
            return new ListData
            {
                Data = list,
                PaginaAtual = pagination.Page,
                QuantidadePaginas = quantidadePaginas,
                RegistrosPorPaginas = pagination.QuantityPerPage,
                TotalRegistros = count,
                TotalRegistrosRetornados = list.Count
            };
        }

        public async Task<Estado> GetAsync(int? id)
        {
            return await _db.Estados.FindAsync(id);
        }

        public async Task<Estado> AddAsync(Estado obj)
        {
            _db.Add(obj);
            await _db.SaveChangesAsync();
            return obj;
        }

        public async Task EditAsync(Estado obj)
        {
            obj.Ativo = true;
            _db.Update(obj);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteAsync(Estado obj)
        {
            obj.Ativo = false;
            _db.Update(obj);
            await _db.SaveChangesAsync();
        }
    }
}