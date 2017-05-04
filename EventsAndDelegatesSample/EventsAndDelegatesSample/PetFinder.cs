using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegatesSample
{
    public class PetFinder
    {
        // 1 Definir el delegate
        public delegate void PetOutOfRangeEventHandler(object sender, EventArgs args);

        // 2 Definir el evento basado en la firma del delegate
        public event PetOutOfRangeEventHandler PetOutOfRange;

        public bool Find(Pet pet)
        {
            if (IsOutOfRange(pet))
            {
                // 3 "Levantar" (raise) del evento
                OnPetOutOfRange(pet);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void OnPetOutOfRange(Pet pet)
        {
            if (PetOutOfRange != null)
            {
                // Se podria pasar la mascota en los argumentos
                // Investigar esto
                PetOutOfRange(this, EventArgs.Empty);
            }
        }

        private bool IsOutOfRange(Pet pet)
        {
            return true;
        }
    }

}
