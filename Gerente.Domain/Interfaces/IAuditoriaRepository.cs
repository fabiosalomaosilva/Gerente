using Gerente.Domain.Enums;

namespace Gerente.Domain.Interfaces
{
    public interface IAuditoriaRepository
    {
        void Audit(object obj, TipoAuditoria tipoAuditoria);
    }
}