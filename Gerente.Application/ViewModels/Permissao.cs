namespace Gerente.Application.ViewModels
{
    public class Permissao
    {
        public string Tabela { get; set; }
        public bool Visualizar { get; set; }
        public bool Adicionar { get; set; }
        public bool Editar { get; set; }
        public bool Excluir { get; set; }
    }
}