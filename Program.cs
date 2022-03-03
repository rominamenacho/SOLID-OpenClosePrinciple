using OpenClosePrinciple.refactor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var notificationsx = new List<INotification>
          {
              new NotificationEmailService("juantopo@email.com", "motivo del correo"),
              new NotificationSmsService("0303456", "asunto de notificacion"),
              // otras nuevas implementaciones
          };

            var notificationService = new NotificationServiceRefactor();
            await notificationService.Send(notificationsx);



        }
    }
}
