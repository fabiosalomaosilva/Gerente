using System.ComponentModel;

namespace Gerente.Application.Enums
{
    public enum SistemaLicitacao
    {
        [Description("Sistema de Registro de Preços")]
        Srp = 1,

        [Description("Comum")]
        Comum = 2,
    }
}