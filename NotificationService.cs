using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    class NotificationService
    {
        public async Task Send(List<Notification> notifications)
        {
            foreach( var notification in notifications)
            {
                if (notification.Type.Equals("sms"))
                {
                    var sms = new Notification
                    {
                        Type = "sms",
                        PhoneNumber = "+051199999999",
                        Subject = "El mensaje del texto"
                    };

                    await SendBySMS(notification.PhoneNumber, notification.Subject);
                }
                if (notification.Type.Equals("email"))
                {
                    var email = new Notification
                    {
                        Type = "email",
                        Email = "customer@email.com",
                        Subject = "El asunto del correo"
                    };
                    await SendByEmail(notification.Email, notification.Subject);

                }
                //si luego aparecen otros medios de notificacion,
                //añadir if romperia el principio
            }
        }


        private async Task SendBySMS(string phoneNumber, string  subject)
        {
            //logica para hacer el envip
        }

        private async Task SendByEmail(string to, string subject)
        {
            // logica para mandar email
        }
    }

    public class Notification
    {
        internal  string Type;
        internal  string PhoneNumber;
        internal  string Subject;
        internal  string Email;
    }
}
