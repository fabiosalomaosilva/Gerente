using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gerente.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;

namespace Gerente.Api
{
    public class ClaimsAuthAttribute : TypeFilterAttribute
    {
        public ClaimsAuthAttribute(string nomeClaim) : base(typeof(ClaimRequirementFilter))
        {
            Arguments = new object[] { nomeClaim };
        }
    }

    public class ClaimRequirementFilter : IAuthorizationFilter
    {
        public string NomeClaim { get; set; }
        public ClaimRequirementFilter(string nomeClaim)
        {
            NomeClaim = nomeClaim;
        }


        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var json = context.HttpContext.User.Claims.FirstOrDefault(p => p.Type == "Permissoes")?.Value;
            var permissoes = JsonConvert.DeserializeObject<IEnumerable<RoleClaimViewModel>>(json);
            var hasClaim = permissoes.Any(c => c.ClaimType == NomeClaim && c.ClaimValue == "true");


            if (!hasClaim)
            {
                context.Result = new ForbidResult();
            }
        }

    }
}
