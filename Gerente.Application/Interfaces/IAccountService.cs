using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Application.ViewModels;

namespace Gerente.Application.Interfaces
{
    public interface IAccountService
    {
        Task<UserLoginResultModel> Login(UserLoginViewModel user);
        void Logout();
        Task<IEnumerable<UsuarioViewModel>> GetAllUsersAsync();
        Task<bool> Register(UsuarioViewModel obj);
        void Edit(UsuarioViewModel obj);
        void ChangePassword(ChangePasswordViewModel obj);
        void ResetPassword(ResetPasswordViewModel resetPasswordModel);
        void DisableUser(UsuarioViewModel obj);
        void EnableUser(UsuarioViewModel obj);
    }
}
