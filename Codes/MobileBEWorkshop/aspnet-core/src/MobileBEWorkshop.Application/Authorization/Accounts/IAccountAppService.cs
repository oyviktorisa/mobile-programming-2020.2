using System.Threading.Tasks;
using Abp.Application.Services;
using MobileBEWorkshop.Authorization.Accounts.Dto;

namespace MobileBEWorkshop.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
