using System;

namespace Task
{
    class BankAccount<T>
    {
        //Скрытые поля данных
        private T num;
        private string name;
        private double balance;

        //Открытые поля
        public T Num
        {
            get
            {
                return num;
            }
            set
            {
                num = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }

        //метод ввода данных
        public void Input()
        {
            Console.WriteLine("Введите номер счета");
            Num = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));

            Console.WriteLine("Введите ФИО владельца счета");
            Name = Console.ReadLine();

            Console.WriteLine("Введите баланс счета");
            Balance = Convert.ToDouble(Console.ReadLine());
        }

        //метод вывода данных в строку
        public string GetInfo()
        {
            return $"Cчет {Num}. Владелец - {Name}, Баланс - {Balance}";
        }

    }
}
