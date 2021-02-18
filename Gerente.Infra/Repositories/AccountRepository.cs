using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Gerente.Domain.Entities;
using Gerente.Domain.Interfaces;
using Gerente.Infra.Data.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Usuario = Gerente.Infra.Data.Models.Usuario;

namespace Gerente.Infra.Data.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly SignInManager<Usuario> _signInManager;
        private readonly UserManager<Usuario> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IMapper _mapper;
        private readonly DataDbContext _context;

        public AccountRepository(SignInManager<Usuario> signInManager, UserManager<Usuario> userManager, RoleManager<IdentityRole> roleManager, IMapper mapper, DataDbContext context)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _roleManager = roleManager;
            _mapper = mapper;
            _context = context;
        }
        public async void Logout()
        {
            await _signInManager.SignOutAsync();
        }
        public async Task<UserLoginResult> LoginAsync(UserLogin user)
        {
            var result = await _signInManager.PasswordSignInAsync(user.Email, user.Password, false, false);
            if (result.Succeeded)
            {
                var usuario = await _userManager.FindByEmailAsync(user.Email);
                var identityRole = _roleManager.Roles.FirstOrDefault(p => p.Name == _userManager.GetRolesAsync(usuario).Result[0]);
                var rolvm = _mapper.Map<Role>(identityRole);
                var claims = await _roleManager.GetClaimsAsync(identityRole);
                var listaClaims = _mapper.Map<IEnumerable<RoleClaim>>(claims);
                return new UserLoginResult
                {
                    Usuario = _mapper.Map<User>(usuario),
                    Role = rolvm,
                    Claims = listaClaims,
                    Succeeded = true,
                    Error = "Usuário logado com sucesso."
                };
            }
            if (result.IsLockedOut)
            {
                return new UserLoginResult
                {
                    Usuario = null,
                    Succeeded = false,
                    Error = "Usuário está suspenso no sistema."
                };
            }
            return new UserLoginResult
            {
                Usuario = null,
                Succeeded = false,
                Error = "Usuário ou senha errados."
            };
        }

        public async Task<IEnumerable<User>> GetAsync()
        {
            var lista = await _userManager.Users.ToListAsync();
            return _mapper.Map<IEnumerable<User>>(lista);
        }

        public async Task<bool> RegisterAsync(User obj, string roleName)
        {
            var user = _mapper.Map<Usuario>(obj);
            user.UserName = user.Email;
            var result = await _userManager.CreateAsync(user, obj.Cpf);
            await _userManager.AddToRoleAsync(user, roleName);
            return result.Succeeded;
        }

        public async void Edit(User obj)
        {
            var user = _mapper.Map<Usuario>(obj);
            await _userManager.UpdateAsync(user);
        }

        public async void ChangePassword(ChangePassword obj)
        {
            var user = _mapper.Map<Usuario>(obj.Usuario);
            await _userManager.ChangePasswordAsync(user, obj.OldPassword, obj.NewPassword);
        }

        public async void ResetPassword(ResetPassword obj)
        {
            var user = _mapper.Map<Usuario>(obj.Usuario);
            await _userManager.ResetPasswordAsync(user, obj.Code, obj.Password);
        }

        public async void DisableUser(User obj)
        {
            var user = _mapper.Map<Usuario>(obj);
            var lockoutEndDate = new DateTime(2999, 01, 01);
            await _userManager.SetLockoutEnabledAsync(user, true);
            await _userManager.SetLockoutEndDateAsync(user, lockoutEndDate);
        }

        public async void EnableUser(User obj)
        {
            var user = _mapper.Map<Usuario>(obj);
            await _userManager.SetLockoutEnabledAsync(user, false);
        }

        public async void AddRole(Role role)
        {
            var lista = _context.RetornaTabelas();
            var identityRole = _mapper.Map<IdentityRole>(role);
            await _roleManager.CreateAsync(identityRole);

            foreach (var i in lista)
            {
                await _roleManager.AddClaimAsync(identityRole, new Claim($"{i}View", "false"));
                await _roleManager.AddClaimAsync(identityRole, new Claim($"{i}Add", "false"));
                await _roleManager.AddClaimAsync(identityRole, new Claim($"{i}Edit", "false"));
                await _roleManager.AddClaimAsync(identityRole, new Claim($"{i}Delete", "false"));
            }
        }

        public async void EditRole(Role role)
        {
            var identityRole = _mapper.Map<IdentityRole>(role);
            await _roleManager.UpdateAsync(identityRole);
        }

        public async void DeleteRole(Role role)
        {
            var identityRole = _mapper.Map<IdentityRole>(role);
            await _roleManager.DeleteAsync(identityRole);
        }

        public async Task<IEnumerable<RoleClaim>> GetClaims(Role role)
        {
            var lista = await _context.RoleClaims.Where(p => p.RoleId == role.Id).ToListAsync();
            return _mapper.Map<IEnumerable<RoleClaim>>(lista);
        }

        public async void EditClaims(Role role, IEnumerable<RoleClaim> claims)
        {
            var lista = await _context.RoleClaims.Where(p => p.RoleId == role.Id).ToListAsync();
            var listaClaims = _mapper.Map<IEnumerable<IdentityRoleClaim<string>>>(claims);
            foreach (var i in lista)
            {
                var item = listaClaims.FirstOrDefault(p => p.Id == i.Id);
                if (i.ClaimValue == item?.ClaimValue) continue;
                i.ClaimValue = item?.ClaimValue;
            }
            _context.UpdateRange(lista);
            await _context.SaveChangesAsync();
        }

    }
}