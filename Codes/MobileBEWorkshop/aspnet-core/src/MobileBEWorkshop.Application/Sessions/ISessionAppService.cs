using System.Threading.Tasks;
using Abp.Application.Services;
using MobileBEWorkshop.Sessions.Dto;

namespace MobileBEWorkshop.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
