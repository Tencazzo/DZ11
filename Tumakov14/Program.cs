using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tumakov14.ClassesforBank;
using Tumakov14.ClassesforBildings;

namespace Tumakov14
{
public class Program
    {
        public static void Main(string[] args)
        {
            Classwork14_1();
            Homework14_1();
        }
        private static void Classwork14_1()
        {
            BankAccount account1 = new BankAccount("Иван Иванов");
            BankAccount account2 = new BankAccount("Петр Петров");
            account1.DumpToScreen();
            account2.DumpToScreen();
        }
        static void Homework14_1()
        {
            var attributes = (DeveloperInfoAttribute[])typeof(Build).GetCustomAttributes(typeof(DeveloperInfoAttribute), false);

            if (attributes.Length > 0)
            {
                var developerInfo = attributes[0];
                Console.WriteLine($"Разработчик: {developerInfo.DeveloperName}");
                Console.WriteLine($"Организация: {developerInfo.Organization}");
            }
            Build build = new Build();
            build[0] = new Building(100, 10, 50, 2);
            build[0].Print();
        }
    }
}
