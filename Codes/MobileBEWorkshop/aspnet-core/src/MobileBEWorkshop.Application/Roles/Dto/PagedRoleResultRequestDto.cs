using Abp.Application.Services.Dto;

namespace MobileBEWorkshop.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

