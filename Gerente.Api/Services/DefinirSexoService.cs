using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Gerente.Api.Services
{
    public class DefinirSexoService
    {
        public static async Task<DefinicaoSexoModel> GetSexo(string nome)
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri("https://servicodados.ibge.gov.br/api/v2/censos/nomes/")
            };
            ResultadosApiDefinirSexo numeroMasculino;
            ResultadosApiDefinirSexo numeroFeminino;
            var numeroM = 0;
            var numeroF = 0;

            try
            {
                var json = await client.GetStringAsync($"{nome}?sexo=m").ConfigureAwait(true);
                if (json != "[]")
                {
                    numeroMasculino = JsonConvert.DeserializeObject<List<ResultadosApiDefinirSexo>>(json)[0];
                }
                else
                {
                    numeroMasculino = new ResultadosApiDefinirSexo {res = new List<Res>()};
                }
            }
            catch
            {
                numeroMasculino = new ResultadosApiDefinirSexo {res = new List<Res>()};
            }

            try
            {
                var json = await client.GetStringAsync($"{nome}?sexo=f").ConfigureAwait(true);
                numeroFeminino = json != "[]"
                    ? JsonConvert.DeserializeObject<List<ResultadosApiDefinirSexo>>(json)[0]
                    : new ResultadosApiDefinirSexo {res = new List<Res>()};
            }
            catch
            {
                numeroFeminino = new ResultadosApiDefinirSexo {res = new List<Res>()};
            }

            foreach (var i in numeroMasculino.res)
            {
                numeroM += i.frequencia;
            }

            foreach (var i in numeroFeminino.res)
            {
                numeroF += i.frequencia;
            }

            var maior = Math.Max(numeroM, numeroF);
            var menor = Math.Min(numeroM, numeroF);
            var sexo = "";

            if (numeroM == numeroF)
            {
                sexo = Sexo.Indefinido;
                return new DefinicaoSexoModel
                {
                    Sexo = sexo,
                    Precisao = "100%"
                };

            }

            if (numeroM == maior)
            {
                sexo = Sexo.Masculino;
            }
            else if (numeroF == maior)
            {
                sexo = Sexo.Feminino;
            }

            decimal rdt = (Convert.ToDecimal(menor) * 100) / Convert.ToDecimal(maior);
            var precisao = Math.Round(100 - rdt, 2);
            return new DefinicaoSexoModel
            {
                Sexo = sexo,
                Precisao = $"{precisao}%"
            };
        }

        public class DefinicaoSexoModel
        {
            public string Sexo { get; set; }
            public string Precisao { get; set; }
        }

        public class ResultadosApiDefinirSexo
        {
            public string nome { get; set; }
            public string sexo { get; set; }
            public string localidade { get; set; }
            public List<Res> res { get; set; }
        }

        public class Res
        {
            public string periodo { get; set; }
            public int frequencia { get; set; }
        }


        public class Sexo
        {
            public static string Masculino => "Masculino";
            public static string Feminino => "Feminino";
            public static string Indefinido => "Indefinido";

        }
    }
}