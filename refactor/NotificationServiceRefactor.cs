using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple.refactor
{
    class NotificationServiceRefactor
    {
        public async Task Send(List<INotification> notifications)
        {
            foreach (var notification in notifications)
            {
                await notification.Notify();
            }
        }

    }
}
//este codigo ya no sera necesario que se modifique, simplemente
//se crear nuevos objetos que implementen la interfaz de notificaciones
//a medida que surjan uevos medios de notif