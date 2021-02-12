using System;

namespace Gerente.Api.Services
{
    public class DefinirImagenService
    {
        public static string SelecionarImagem(string nomeCategoria)
        {
            switch (nomeCategoria.Trim().ToLower())
            {
                case "internet":
                    return "https://fundhacre.blob.core.windows.net/icones/internet.png";
                case "ar condicionado":
                    return "https://fundhacre.blob.core.windows.net/icones/ar_condicionado.png";
                case "computador":
                    return "https://fundhacre.blob.core.windows.net/icones/computador.png";
                case "categoria":
                    return "https://fundhacre.blob.core.windows.net/icones/categorias.png";
                case "impressora":
                    return "https://fundhacre.blob.core.windows.net/icones/impressora.png";
                case "lampada":
                    return "https://fundhacre.blob.core.windows.net/icones/lampada.png";
                case "luminária":
                    return "https://fundhacre.blob.core.windows.net/icones/lampada.png";
                case "lavanderia":
                    return "https://fundhacre.blob.core.windows.net/icones/lavanderia.png";
                case "lavatorio":
                    return "https://fundhacre.blob.core.windows.net/icones/lavatorio.png";
                case "periférico":
                    return "https://fundhacre.blob.core.windows.net/icones/perifericos.png";
                case "tomada":
                    return "https://fundhacre.blob.core.windows.net/icones/tomada.png";
                case "torneira":
                    return "https://fundhacre.blob.core.windows.net/icones/torneira.png";
                case "acesso de usuário":
                    return "https://fundhacre.blob.core.windows.net/icones/usuarios.png";
                case "datashow":
                    return "https://fundhacre.blob.core.windows.net/icones/datashow.png";
                case "e-mail":
                    return "https://fundhacre.blob.core.windows.net/icones/email.png";
                case "encanação":
                    return "https://fundhacre.blob.core.windows.net/icones/encanacao.png";
                case "arquivos":
                    return "https://fundhacre.blob.core.windows.net/icones/arquivos.png";
                default:
                    return "https://fundhacre.blob.core.windows.net/icones/config.png";
            }
        }
        public static string SelecionarBackground(string nomeServico)
        {
            switch (nomeServico.Trim().ToLower())
            {
                case "informática":
                    return "https://fundhacre.blob.core.windows.net/icones/fundo_informatica.jpg";
                case "serviços gerais":
                    return "https://fundhacre.blob.core.windows.net/icones/fundo_eletricidade.jpg";
            }
            return "https://fundhacre.blob.core.windows.net/icones/fundo_obra.jpg";
        }

        public static string SelecionarAvatar(string sexo)
        {
            var r = new Random();
            var idAvatar = r.Next(1, 10);

            return sexo.Trim().ToLower() switch
            {
                "Masculino" => $"https://fundhacre.blob.core.windows.net/avatar/masculino{idAvatar}.png",
                "Feminino" => $"https://fundhacre.blob.core.windows.net/avatar/feminino{idAvatar}.png",
                "Indefinido" => $"https://fundhacre.blob.core.windows.net/avatar/feminino{idAvatar}.png",
                _ => $"https://fundhacre.blob.core.windows.net/avatar/masculino{idAvatar}.png"
            };
        }


    }
}