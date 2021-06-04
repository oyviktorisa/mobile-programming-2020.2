using Abp.Application.Services;
using MobileBEWorkshop.MultiTenancy.Dto;

namespace MobileBEWorkshop.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

