using System.Threading.Tasks;
using MobileBEWorkshop.Configuration.Dto;

namespace MobileBEWorkshop.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
