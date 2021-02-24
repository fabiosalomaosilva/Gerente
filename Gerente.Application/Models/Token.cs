using System.Collections.Generic;
using Gerente.Application.ViewModels;
using Gerente.Domain.Entities;

namespace Gerente.Application.Models
{
    public class Token
    {
        public string access_token { get; set; }
        public string token_type { get; set; }
        public string id { get; set; }
        public int expires_in { get; set; }
        public string email { get; set; }
        public string nomeCompleto { get; set; }
        public int secretariaId { get; set; }
        public string secretaria { get; set; }
        public string setor { get; set; }
        public int setorId { get; set; }
        public string fotoUri { get; set; }
        public string issued { get; set; }
        public string expires { get; set; }
        public string permissoes { get; set; }
    }
}