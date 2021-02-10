namespace Gerente.Infra.Data.Models
{
    public class PaginationDTO
    {
        public int Page { get; set; } = 1;
        public int QuantityPerPage { get; set; } = 10;
    }
}
