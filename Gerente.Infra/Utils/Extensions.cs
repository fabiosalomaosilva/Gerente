using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Gerente.Infra.Data
{
    public static class Extensions
    {
        public static List<string> RetornaTabelas(this DbContext context)
        {
            var dbSetProperties = new List<string>();
            var properties = context.GetType().GetProperties();
            foreach (var property in properties)
            {
                var setType = property.PropertyType;

                var isDbSet = setType.IsGenericType && (typeof(DbSet<>).IsAssignableFrom(setType.GetGenericTypeDefinition()));
                var listaEnt = new string[] { "UserRoles", "Roles", "RoleClaims", "Users", "UserClaims", "UserLogins", "UserTokens" };
                if (isDbSet && !listaEnt.Contains(property.Name))
                {
                    dbSetProperties.Add(property.Name);
                }
            }
            return dbSetProperties;
        }
    }
}
