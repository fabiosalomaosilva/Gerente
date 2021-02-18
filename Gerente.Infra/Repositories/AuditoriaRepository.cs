using System;
using Gerente.Domain.Entities;
using Gerente.Domain.Enums;
using Gerente.Infra.Data.Context;
using Newtonsoft.Json;

namespace Gerente.Infra.Data.Repositories
{
    public class AuditoriaRepository<T>
    {
        private readonly DataDbContext _db;

        public AuditoriaRepository(DataDbContext db)
        {
            _db = db;
        }
        private async void Auditar(T obj, TipoAuditoria tipoAuditoria)
        {
            var tabela = typeof(T).Name;
            try
            {
                var aud = new Auditoria
                {
                    Id = Guid.Empty.ToString(),
                    IdObjeto = GetId(obj),
                    Operacao = tipoAuditoria.ToString(),
                    Tabela = tabela,
                    AuditadoPor = GetUser(obj),
                    AuditadoEm = DateTime.Now
                };

                if (tipoAuditoria == TipoAuditoria.Exclusao)
                {
                    aud.Valor = null;
                }
                else
                {
                    aud.Valor = JsonConvert.SerializeObject(obj, Formatting.None);
                }

                _db.Add(aud);
                await _db.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                //InformarErro.InsertAsync(_user.ClientId, idObjeto, tabela, auditoriaOperacao, LocalErro.Auditoria);
                throw new Exception(ex.Message);
            }
        }

        private int GetId(T obj)
        {
            var id = 0;
            var props = obj.GetType().GetProperties();
            foreach (var prop in props)
            {
                if (prop.PropertyType.Name == "Int")
                {
                    if (prop.Name == "Id")
                    {
                        id = Convert.ToInt32(prop.GetValue(obj, null));
                        return id;
                    }
                }
            }

            return id;
        }
        private string GetUser(T obj)
        {
            var id = string.Empty;
            var props = obj.GetType().GetProperties();
            foreach (var prop in props)
            {
                if (prop.PropertyType.Name != "String" && prop.Name != "AlteradoPor") continue;
                id = Convert.ToString(prop.GetValue(obj, null));
                return id;
            }
            return id;
        }
    }
}