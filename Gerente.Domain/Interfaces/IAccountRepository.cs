using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Domain.Entities;

namespace Gerente.Domain.Interfaces
{
    public interface IAccountRepository
    {
        Task<UserLoginResult> LoginAsync(UserLogin user);
        void Logout();
        Task<IEnumerable<User>> GetAsync();
        Task<bool> RegisterAsync(User obj, string roleName);
        void Edit(User obj);
        void ChangePassword(ChangePassword obj);
        void ResetPassword(ResetPassword obj);
        void DisableUser(User obj);
        void EnableUser(User obj);
        void AddRole(Role role);
        void EditRole(Role role);
        void DeleteRole(Role role);
        Task<IEnumerable<RoleClaim>> GetClaims(Role role);
        void EditClaims(Role role, IEnumerable<RoleClaim> claims);
    }
}
