using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace StreamReaderDemo
{
    class Program
    {



        static void Main()
        {
                Random random = new Random();
                int number;
                int random_number = random.Next(1, 100);
                Console.WriteLine("Добро пожаловать в игру 'Угадай число'!");
                Console.WriteLine("Правила игры: компьютер загадывает число от 1 до 100, ваша задача его отдагадать. Если хотите закончить игру напишите 'Выход'. Если хотите начать заново напишите 'Заново'.");
                Console.WriteLine("Желаете начать?(Да/Нет)");
                string answer = Console.ReadLine();
                if (answer == "Нет")
                {
                    Environment.Exit(0);
                }
                else if (answer == "Да")
                {
                    Play();
                }
                else
                {
                    Console.WriteLine("Ошибка. Ответ неккоректен");
                }
            void Play()
            {
                Console.WriteLine("Компьютер загадал число. Попробуйте его отгадать");
                Console.WriteLine("Ответ:");
                string choice = Console.ReadLine();

                if (choice == "Выход")
                {
                    Environment.Exit(0);
                }
                else if (choice=="Заново")
                {
                    Main();
                }
                else if (int.TryParse(choice, out number))
                {
                    if (number == random_number)
                    {
                        Console.WriteLine("Поздравляем, вы победили! Желаете начать заново?(Да/Нет)");
                        Console.WriteLine("Ответ:");
                        string answer2 = Console.ReadLine();
                        if (answer2 == "Нет")
                        {
                            Environment.Exit(0);
                        }
                        else if (answer2 == "Да")
                        {
                            Main();

                        }
                    }
                    else if (number !=random_number)
                    {
                        Console.WriteLine("Вы не угадали. Попробуйте еще раз!");
                        Play();
                    }

                }
                else
                {
                    Console.WriteLine("Ошибка. Ответ неккоректен");
                }



            }
        }
    }
}
    

