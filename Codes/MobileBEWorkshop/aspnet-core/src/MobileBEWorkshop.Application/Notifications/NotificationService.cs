using System.Net.Http;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using FcmSharp;
using FcmSharp.Requests;
using MobileBEWorkshop.Notifications.DTO;
using System;

namespace MobileBEWorkshop.Notifications
{
    public class NotificationService : INotificationService
    {
        private FcmApp Firebase { get; set; }

        public NotificationService(FcmApp _firebase)
        {
            Firebase = _firebase;
        }

        public void CreateNotification(NotificationDTO dto)
        {
            using (var client = new FcmClient(Firebase.FcmSetting))
            {
                Console.WriteLine(Firebase.FcmSetting.Credentials);

                var notification = new Notification
                {
                    Title = dto.Title,
                    Body = dto.Body
                };

                var message = new FcmMessage()
                {
                    ValidateOnly = false,
                    Message = new Message
                    {
                        Topic = "flutterfire",
                        Notification = notification
                    }
                };

                CancellationTokenSource cts = new CancellationTokenSource();
                var result = client.SendAsync(message, cts.Token).GetAwaiter().GetResult();

                Console.WriteLine(result.Name);
            }
        }
    }

}