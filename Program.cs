using System;

namespace DZ_7Practic
{
    
        public class Account
        {
            int trys { get; set; }

            static void TryPassword(string password, string clientPassword, int trys, int money)
            {
                bool x = true;
                while (x)
                {
                    Console.WriteLine("Введите пароль");
                    clientPassword = Console.ReadLine();
                    if (clientPassword == password)
                    {
                        Console.WriteLine("Верно");
                        Menu(money);
                    }
                    else
                    {
                        Console.WriteLine("Неверно");
                        trys++;
                        if (trys == 3)
                        {
                            x = false;
                        }
                    }
                }
            }
            static void Menu(int money)
            {
                bool x = true;
                while (x)
                {
                    int a;
                    Console.WriteLine(" 1 - Баланс");
                    Console.WriteLine(" 2 - Пополнить");
                    Console.WriteLine(" 3 - Вывести");
                    Console.WriteLine(" 4 - Выход");
                    a = int.Parse(Console.ReadLine());
                    switch (a)
                    {
                        case 1: BalanceShowing(money); x = false; break;
                        case 2: BalanceGiving(money); x = false; break;
                        case 3: BalanceTaking(money); x = false; break;
                        case 4: x = false; break;
                        default: break;
                    }
                }
                static void BalanceShowing(int money)
                {
                    Console.WriteLine("Ваш баланс");
                    Console.WriteLine(money);
                    Menu(money);
                }
                static void BalanceGiving(int money)
                {
                    int giving;
                    Console.WriteLine("Сколько ввести");
                    giving = int.Parse(Console.ReadLine());
                    if (money >= giving)
                    {

                        Menu(money);

                    }
                    else
                    {
                        Console.WriteLine("У вас нет суммы");
                        Menu(money);
                    }
                }
                static void BalanceTaking(int money)
                {
                    int taking;
                    Console.WriteLine("Сколько залить?");
                    taking = int.Parse(Console.ReadLine());
                    if (taking > 0)
                    {
                        money += taking;
                        Menu(money);
                    }
                    else
                    {
                        Console.WriteLine("Неправельная сумма");
                        Menu(money);
                    }
                }

            }

        }
        public class Banc
        {
            int money { get; set; }
        }
        public class Client
        {
            string name { get; set; }
            string password { get; set; }

        }
}

