using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Application.ViewModels;
using Gerente.Domain.Entities;

namespace Gerente.Application.Interfaces
{
    public interface IAccountService
    {
        Task<UserLoginResultModel> Login(UserLoginViewModel user);
        void Logout();
        Task<IEnumerable<UsuarioViewModel>> GetAllUsersAsync();
        Task<bool> Register(UsuarioViewModel obj, string roleName);
        void Edit(UsuarioViewModel obj);
        void ChangePassword(ChangePasswordViewModel obj);
        void ResetPassword(ResetPasswordViewModel resetPasswordModel);
        void DisableUser(UsuarioViewModel obj);
        void EnableUser(UsuarioViewModel obj);
        void AddRole(RoleViewModel role);
        void EditRole(RoleViewModel role);
        void DeleteRole(RoleViewModel role);
        Task<IEnumerable<RoleClaimViewModel>> GetClaims(RoleViewModel role);
        void EditClaims(RoleViewModel role, IEnumerable<RoleClaimViewModel> claims);
    }
}
