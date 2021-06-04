using Abp.AutoMapper;
using MobileBEWorkshop.Authentication.External;

namespace MobileBEWorkshop.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
