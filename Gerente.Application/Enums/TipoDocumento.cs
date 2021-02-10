using System.ComponentModel;

namespace Gerente.Application.Enums
{
    public enum TipoDocumento
    {
        [Description("Documento pessoal")]
        DocumentoPessoal = 1,

        [Description("Comprovante de residência")]
        ComprovanteResidencia = 2,

        [Description("Conta bancária")]
        ContaBancaria = 3,

        [Description("Parecer médico")]
        ParecerMedico = 4,

        [Description("Orçamento")]
        Orcamento = 5,

        [Description("Receituário")]
        Receituario = 6,
        Laudo = 7,

        [Description("Protuário")]
        Prontuario = 8,

        [Description("Alta médica")]
        AltaMedica = 9,

        [Description("Contrato")]
        Contrato = 10,

        [Description("Aditivo de contrato")]
        Aditivo = 11,

        [Description("Ata de Registro de Preços")]
        AtaSrp = 12,

        [Description("Empenho")]
        Empenho = 13,
        [Description("Liquidação")]
        Liquidacao = 14,

        [Description("Ordem de Pagamento")]
        OrdemPagamento = 15,

        Outros = 16
    }
}