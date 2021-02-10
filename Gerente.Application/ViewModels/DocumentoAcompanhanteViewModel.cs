using Gerente.Application.Enums;

namespace Gerente.Application.ViewModels
{
    public class DocumentoAcompanhanteViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Url { get; set; }
        public int AcompanhanteId { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
    }
}