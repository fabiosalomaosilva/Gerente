using System.ComponentModel.DataAnnotations;

namespace Gerente.Domain.Entities
{
    public class ControleVersaoEndereco : ControleVersao
    {

        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public int EstadoId { get; set; }
        public virtual Estado Estado { get; set; }
        public int MunicipioId { get; set; }
        public virtual Municipio Municipio { get; set; }
    }
}