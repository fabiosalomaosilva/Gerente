using System.ComponentModel;

namespace Gerente.Domain.Enums
{
    public enum ModalidadeLicitacao
    {
        [Description("Pregão")]
        Pregao = 1,

        [Description("Dispensa de licitação")]
        Dispensa = 2,
        [Description("Inexigibilidade de licitação")]
        Inexigibilidade = 3,

        [Description("Tomada de Preços")]
        TomadaPrecos = 4,

        [Description("Concorrência")]
        Concorrencia = 5,

        [Description("Chamamento público")]
        Chamamento = 6,
    }
}