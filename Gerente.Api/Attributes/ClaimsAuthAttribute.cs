using Gerente.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace Gerente.Api
{
    public class ClaimsAuthAttribute : TypeFilterAttribute
    {
        public ClaimsAuthAttribute(TipoAction tipoAction, string nomeController) : base(typeof(ClaimRequirementFilter))
        {
            Arguments = new object[] { tipoAction, nomeController };
        }
    }

    public class ClaimRequirementFilter : IAuthorizationFilter
    {
        public string NomeController { get; set; }
        public TipoAction TipoAction { get; set; }
        public ClaimRequirementFilter(TipoAction tipoAction, string nomeController)
        {
            TipoAction = tipoAction;
            NomeController = nomeController;
        }


        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var json = context.HttpContext.User.Claims.FirstOrDefault(p => p.Type == "Permissoes")?.Value;
            var permissoes = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
            var claim = permissoes.FirstOrDefault(c => c.Key == NomeController);
            string valorPermissao = "0";
            switch (TipoAction)
            {
                case TipoAction.Get:
                    valorPermissao = claim.Value.Split(',')[0];
                    break;
                case TipoAction.Post:
                    valorPermissao = claim.Value.Split(',')[1];
                    break;
                case TipoAction.Put:
                    valorPermissao = claim.Value.Split(',')[2];
                    break;
                case TipoAction.Delete:
                    valorPermissao = claim.Value.Split(',')[3];
                    break;
                default:
                    break;
            }

            if (valorPermissao == "0")
            {
                context.Result = new ForbidResult();
            }
        }

    }
}
