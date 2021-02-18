using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Gerente.Application.Mappings;
using Gerente.Application.ViewModels;
using Gerente.Domain.Entities;
using Gerente.Infra.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace Gerente.Api.MappingConfig
{
    public static class AutoMapperConfig
    {
        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));
            services.AddAutoMapper(typeof(DomainToViewModelMapping), typeof(ViewModelToDomainMapping));
            services.AddAutoMapper(typeof(DomainUserToViewModelMapping), typeof(ViewModelToDomainUserMapping));
        }
    }

    public class DomainUserToViewModelMapping : Profile
    {
        public DomainUserToViewModelMapping()
        {
            CreateMap<User, Usuario>();
            CreateMap<UserLogin, UserLoginViewModel>();
            CreateMap<UserLoginResult, UserLoginResultModel>();
            CreateMap<Role, IdentityRole>();
            CreateMap<RoleClaim, IdentityRoleClaim<string>>();
            CreateMap<RoleClaim, Claim>();
        }
    }
    public class ViewModelToDomainUserMapping : Profile
    {
        public ViewModelToDomainUserMapping()
        {
            CreateMap<Usuario, User>();
            CreateMap<UserLoginViewModel, UserLogin>();
            CreateMap<UserLoginResultModel, UserLoginResult>();
            CreateMap<IdentityRole, Role>();
            CreateMap<IdentityRoleClaim<string>, RoleClaim>();
            CreateMap<Claim, RoleClaim>();
        }
    }
}
