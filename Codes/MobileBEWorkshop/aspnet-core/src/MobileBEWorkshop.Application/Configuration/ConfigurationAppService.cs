using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using MobileBEWorkshop.Configuration.Dto;

namespace MobileBEWorkshop.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MobileBEWorkshopAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
