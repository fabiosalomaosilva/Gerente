using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Domain.Entities;

namespace Gerente.Domain.Interfaces
{
    public interface IAccountRepository
    {
        Task<UserLoginResult> LoginAsync(UserLogin user);
        Task LogoutAsync();
        Task<IEnumerable<User>> GetAsync();
        Task<bool> RegisterAsync(User obj, string roleName);
        Task EditAsync(User obj);
        Task ChangePasswordAsync(ChangePassword obj);
        Task ResetPassword(ResetPassword obj);
        Task DisableUserAsync(User obj);
        Task EnableUserAsync(User obj);
        Task AddRoleAsync(Role role);
        Task EditRoleAsync(Role role);
        Task DeleteRoleAsync(Role role);
        Task<IEnumerable<RoleClaim>> GetClaimsAsync(Role role);
        Task EditClaimsAsync(Role role, IEnumerable<RoleClaim> claims);
    }
}
