namespace Gerente.Infra.Data.Models
{
    public class ListData
    {
        public object Data { get; set; }
        public int TotalRegistros { get; set; }
        public int TotalRegistrosRetornados { get; set; }
        public int PaginaAtual { get; set; }
        public int QuantidadePaginas { get; set; }
        public int RegistrosPorPaginas { get; set; }
    }
}