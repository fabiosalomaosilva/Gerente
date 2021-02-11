using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Gerente.Domain.Entities;
using Gerente.Domain.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.V4.Pages.Account.Internal;
using Microsoft.AspNetCore.Identity.UI.V4.Pages.Account.Manage.Internal;
using Microsoft.EntityFrameworkCore;
using Usuario = Gerente.Infra.Data.Models.Usuario;

namespace Gerente.Infra.Data.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly SignInManager<Usuario> _signInManager;
        private readonly UserManager<Usuario> _userManager;
        private readonly IMapper _mapper;

        public AccountRepository(SignInManager<Usuario> signInManager, UserManager<Usuario> userManager, IMapper mapper)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _mapper = mapper;
        }
        public async void Logout()
        {
            await _signInManager.SignOutAsync();
        }
        public async Task<UserLoginResult> LoginAsync(UserLogin user)
        {
            var result = await _signInManager.PasswordSignInAsync(user.Username, user.Password, false, false);
            if (result.Succeeded)
            {
                var usuario = await _userManager.FindByEmailAsync(user.Username);
                return new UserLoginResult
                {
                    Usuario = _mapper.Map<User>(usuario),
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

        public async Task<bool> RegisterAsync(User obj)
        {
            var user = _mapper.Map<Usuario>(obj);
            var result = await _userManager.CreateAsync(user, obj.Cpf);
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
    }
}