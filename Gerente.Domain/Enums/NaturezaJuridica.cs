using System.ComponentModel;

namespace Gerente.Domain.Enums
{
    public enum NaturezaJuridica
    {
        [Description("Pessoa jurídica")]
        PessaoJuridica,

        [Description("Pessoa física")]
        PessoaFisica
    }
}