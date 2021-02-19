using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Application.ViewModels;
using Gerente.Domain.Entities;

namespace Gerente.Application.Interfaces
{
    public interface IAccountService
    {
        Task<UserLoginResultModel> LoginAsync(UserLoginViewModel user);
        Task LogoutAsync();
        Task<IEnumerable<UsuarioViewModel>> GetAllUsersAsync();
        Task<bool> RegisterAsync(UsuarioViewModel obj, string roleName);
        Task EditAsync(UsuarioViewModel obj);
        Task ChangePasswordAsync(ChangePasswordViewModel obj);
        Task ResetPasswordAsync(ResetPasswordViewModel resetPasswordModel);
        Task DisableUserAsync(UsuarioViewModel obj);
        Task EnableUserAsync(UsuarioViewModel obj);
        Task AddRoleAsync(RoleViewModel role);
        Task EditRoleAsync(RoleViewModel role);
        Task DeleteRoleAsync(RoleViewModel role);
        Task<IEnumerable<RoleClaimViewModel>> GetClaimsAsync(RoleViewModel role);
        Task EditClaimsAsync(RoleViewModel role, IEnumerable<RoleClaimViewModel> claims);
    }
}
