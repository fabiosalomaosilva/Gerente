namespace Gerente.Infra.Data.Models
{
    public class Token
    {
        public string access_token { get; set; }
        public string token_type { get; set; }
        public string id { get; set; }
        public int expires_in { get; set; }
        public string email { get; set; }
        public string nomeCompleto { get; set; }
        public string cargoId { get; set; }
        public string cargo { get; set; }
        public string setorId { get; set; }
        public string clientId { get; set; }
        public string fotoUri { get; set; }
        public string setor { get; set; }
        public string issued { get; set; }
        public string expires { get; set; }
    }
}