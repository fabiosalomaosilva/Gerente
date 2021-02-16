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
        public async Task<UserLoginResultModel> Login(UserLoginViewModel user)
        {
            var obj = _mapper.Map<UserLogin>(user);
            var result = await _service.LoginAsync(obj);
            var userResult = _mapper.Map<UserLoginResultModel>(result);
            return userResult;
        }

        public void Logout()
        {
            _service.Logout();
        }

        public async Task<IEnumerable<UsuarioViewModel>> GetAllUsersAsync()
        {
            var lista = await _service.GetAsync();
            return _mapper.Map<IEnumerable<UsuarioViewModel>>(lista);
        }

        public async Task<bool> Register(UsuarioViewModel obj, string roleName)
        {
            return await _service.RegisterAsync(_mapper.Map<User>(obj), roleName);
        }

        public void Edit(UsuarioViewModel obj)
        {
            _service.Edit(_mapper.Map<User>(obj));
        }

        public void ChangePassword(ChangePasswordViewModel obj)
        {
            _service.ChangePassword(_mapper.Map<ChangePassword>(obj));
        }

        public void ResetPassword(ResetPasswordViewModel resetPasswordModel)
        {
            _service.ResetPassword(_mapper.Map<ResetPassword>(resetPasswordModel));
        }

        public void DisableUser(UsuarioViewModel obj)
        {
            _service.DisableUser(_mapper.Map<User>(obj));
        }

        public void EnableUser(UsuarioViewModel obj)
        {
            _service.EnableUser(_mapper.Map<User>(obj));
        }

        public void AddRole(RoleViewModel role)
        {
            _service.AddRole(_mapper.Map<Role>(role));
        }

        public void EditRole(RoleViewModel role)
        {
            _service.EditRole(_mapper.Map<Role>(role));
        }

        public void DeleteRole(RoleViewModel role)
        {
            _service.DeleteRole(_mapper.Map<Role>(role));
        }

        public async Task<IEnumerable<RoleClaimViewModel>> GetClaims(RoleViewModel role)
        {
            var lista = await _service.GetClaims(_mapper.Map<Role>(role));
            return _mapper.Map<IEnumerable<RoleClaimViewModel>>(lista);
        }

        public void EditClaims(RoleViewModel role, IEnumerable<RoleClaimViewModel> claims)
        {
            var r = _mapper.Map<Role>(role);
            var cs = _mapper.Map<IEnumerable<RoleClaim>>(claims);
            _service.EditClaims(r, cs);
        }


    }
}