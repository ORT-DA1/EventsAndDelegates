using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegatesSample
{
    public class MailNotificationService
    {
        public void SendNotificationPetOutOfRange(object sender, EventArgs args)
        {
            Console.WriteLine($"La mascota esta fuera de Rango!!! Soy un mail muy lindo");
        }
    }
}
