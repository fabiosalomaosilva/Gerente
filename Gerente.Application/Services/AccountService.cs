using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Gerente.Application.Interfaces;
using Gerente.Application.ViewModels;
using Gerente.Domain.Entities;
using Gerente.Domain.Interfaces;

namespace Gerente.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _service;
        private readonly IMapper _mapper;

        public AccountService(IAccountRepository service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        public async Task<UserLoginResultModel> LoginAsync(UserLoginViewModel user)
        {
            var obj = _mapper.Map<UserLogin>(user);
            var result = await _service.LoginAsync(obj);
            var userResult = _mapper.Map<UserLoginResultModel>(result);
            return userResult;
        }

        public async Task LogoutAsync()
        {
            await _service.LogoutAsync();
        }

        public async Task<IEnumerable<UsuarioViewModel>> GetAllUsersAsync()
        {
            var lista = await _service.GetAsync();
            return _mapper.Map<IEnumerable<UsuarioViewModel>>(lista);
        }

        public async Task<bool> RegisterAsync(UsuarioViewModel obj, string roleName)
        {
            return await _service.RegisterAsync(_mapper.Map<User>(obj), roleName);
        }

        public async Task EditAsync(UsuarioViewModel obj)
        {
            await _service.EditAsync(_mapper.Map<User>(obj));
        }

        public async Task ChangePasswordAsync(ChangePasswordViewModel obj)
        {
            await _service.ChangePasswordAsync(_mapper.Map<ChangePassword>(obj));
        }

        public async Task ResetPasswordAsync(ResetPasswordViewModel resetPasswordModel)
        {
            await _service.ResetPassword(_mapper.Map<ResetPassword>(resetPasswordModel));
        }

        public async Task DisableUserAsync(UsuarioViewModel obj)
        {
            await _service.DisableUserAsync(_mapper.Map<User>(obj));
        }

        public async Task EnableUserAsync(UsuarioViewModel obj)
        {
            await _service.EnableUserAsync(_mapper.Map<User>(obj));
        }

        public async Task AddRoleAsync(RoleViewModel role)
        {
            await _service.AddRoleAsync(_mapper.Map<Role>(role));
        }

        public async Task EditRoleAsync(RoleViewModel role)
        {
            await _service.EditRoleAsync(_mapper.Map<Role>(role));
        }
            
        public async Task DeleteRoleAsync(RoleViewModel role)
        {
            await _service.DeleteRoleAsync(_mapper.Map<Role>(role));
        }

        public async Task<IEnumerable<RoleClaimViewModel>> GetClaimsAsync(RoleViewModel role)
        {
            var lista = await _service.GetClaimsAsync(_mapper.Map<Role>(role));
            return _mapper.Map<IEnumerable<RoleClaimViewModel>>(lista);
        }

        public async Task EditClaimsAsync(RoleViewModel role, IEnumerable<RoleClaimViewModel> claims)
        {
            var r = _mapper.Map<Role>(role);
            var cs = _mapper.Map<IEnumerable<RoleClaim>>(claims);
            await _service.EditClaimsAsync(r, cs);
        }


    }
}