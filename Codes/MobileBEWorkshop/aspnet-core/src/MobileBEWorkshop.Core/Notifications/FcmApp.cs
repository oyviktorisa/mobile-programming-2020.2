using System.Security.AccessControl;
using System.IO;
using Abp.Dependency;
using FcmSharp.Settings;

namespace MobileBEWorkshop.Notifications
{
    public class FcmApp : ITransientDependency
    {
        public FcmClientSettings FcmSetting { get; set; }
        public FcmApp()
        {
            FcmSetting = FileBasedFcmClientSettings.CreateFromFile($"{Directory.GetCurrentDirectory()}\\flutterfiredemo-firebase-admin.json");
        }
    }
}