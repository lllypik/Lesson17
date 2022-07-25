using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {

            //Пример экземпляров класса заданных заранее
            BankAccount<int> account_1 = new BankAccount<int>() { Num = 1, Name = "Иванов", Balance = 10000 };
            BankAccount<string> account_2 = new BankAccount<string>() { Num = 1F, Name = "Петров", Balance = -10000 };

            //Задание экземпляров класса с помощью ручного ввода
            BankAccount<int> account_3 = new BankAccount<int>();
            BankAccount<string> account_4 = new BankAccount<string>();
            account_3.Input();
            account_4.Input();

            //Вывод на консоль полученных данных
            Console.WriteLine(account_1.GetInfo());
            Console.WriteLine(account_2.GetInfo());
            Console.WriteLine(account_3.GetInfo());
            Console.WriteLine(account_4.GetInfo());

            Console.ReadKey();

            //Подскажите, почему не заработал данный с массивом данных, не смог сформировать массив даже
            //с учетом параметра номера счета в int? Не смог нигде найти место, где ошибся в синтаксисе ((

            //int amount;

            //Console.WriteLine("Введите число владельцев счетов");
            //amount = Convert.ToInt32(Console.ReadLine());

            //BankAccount<int>[] accounts = new BankAccount<int>[amount];
            //for (int i = 0; i < amount; i++)
            //{
            //    accounts[i].Input();
            //}

            //Console.ReadKey();

        }
    }
}
