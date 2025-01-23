using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ11.ClassesforBildings
{
    public class Building
    {
        private static int unique = 0;
        public string Id { get; private set; }
        public float Height { get; set; }
        public int Floors { get; set; }
        public int ApartmentAmount { get; set; }
        public int EntranceAmount { get; set; }

        public Building(float height, int floors, int apartmentAmount, int entranceAmount)
        {
            unique++;
            Id = unique.ToString();
            Height = height;
            Floors = floors;
            ApartmentAmount = apartmentAmount;
            EntranceAmount = entranceAmount;
        }

        public void Print()
        {
            Console.WriteLine("ID: " + Id + ", Высота: " + Height + ", Этажи: " + Floors +
                              ", Квартир: " + ApartmentAmount + ", Подъездов: " + EntranceAmount);
        }

        public float FloorHeight()
        {
            return Floors == 0 ? 0 : Height / Floors;
        }

        public float ApartmentsPerFloor()
        {
            return Floors == 0 ? 0 : ApartmentAmount / Floors;
        }

        public float ApartmentsPerEntrance()
        {
            return EntranceAmount == 0 ? 0 : ApartmentAmount / EntranceAmount;
        }
    }

}
