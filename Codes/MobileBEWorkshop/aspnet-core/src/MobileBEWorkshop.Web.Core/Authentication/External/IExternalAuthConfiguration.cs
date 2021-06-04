using System.Collections.Generic;

namespace MobileBEWorkshop.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
