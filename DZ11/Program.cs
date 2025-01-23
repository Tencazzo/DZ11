using DZ11.ClassesClassesforBank;
using DZ11.ClassesforBildings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Classwork();
            Homework();
        }

        static void Classwork()
        {
            AccountAdministration manager = new AccountAdministration();

            string accountNumber1 = manager.CreateAccount("Иван Иванов");
            Console.WriteLine("Создан счет с номером: " + accountNumber1);

            string accountNumber2 = manager.CreateAccount("Петр Петров");
            Console.WriteLine("Создан счет с номером: " + accountNumber2);

            var account1 = manager.GetAccount(accountNumber1);
            account1.Deposit(1000);
            Console.WriteLine("Баланс после депозита" + accountNumber1 + ": " + account1.AccountNumber);

            account1.Withdraw(200);
            Console.WriteLine("Баланс после снятия денег" + accountNumber1 + ": " + account1.AccountNumber);

            var account2 = manager.GetAccount(accountNumber2);
            account1.Transfer(account2, 300);
            Console.WriteLine("Баланс первого счета после перевода: " + account1.AccountNumber);
            Console.WriteLine("Баланс второго счета после перевода: " + account2.AccountNumber);
        }

        static void Homework()
        {
            Building building1 = new Building(76, 9, 36, 1);
            Building building2 = new Building(50, 5, 20, 1);

            building1.Print();
            building2.Print();

            Console.WriteLine("Высота этажа здания 1: " + building1.FloorHeight());
            Console.WriteLine("Квартир на этаже здания 1: " + building1.ApartmentsPerFloor());
            Console.WriteLine("Квартир в подъезде здания 1: " + building1.ApartmentsPerEntrance());

            Build zastroika = new Build();
            zastroika[0] = building1;
            zastroika[1] = building2;

            for (int i = 0; i < 2; i++)
            {
                Building building = zastroika[i];
                building.Print();
                Console.WriteLine("Высота этажа: " + building.FloorHeight() +
                                  ", Квартир на этаже: " + building.ApartmentsPerFloor() +
                                  ", Квартир в подъезде: " + building.ApartmentsPerEntrance());
            }
        }
    }
}

