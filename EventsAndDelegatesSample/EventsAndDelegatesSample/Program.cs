using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegatesSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet bobby = new Pet { Name = "El Bobby", Breed = "Pug" };
            PetFinder petFinder = new PetFinder();

            MailNotificationService mailService = new MailNotificationService();
            petFinder.PetOutOfRange += mailService.SendNotificationPetOutOfRange;

            petFinder.Find(bobby);
            Console.ReadKey();
        }
    }
}
