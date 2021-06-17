using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Dependency;
using MobileBEWorkshop.Notifications.DTO;

namespace MobileBEWorkshop.Notifications
{
    public interface INotificationService : IApplicationService, ITransientDependency
    {
        public void CreateNotification(NotificationDTO dto);
    }
}