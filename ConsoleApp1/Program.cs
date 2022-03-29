// See https://aka.ms/new-console-template for more information
using System;

namespace ConsoleApp1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        enum GAME
        {
            Регистрация = 1,
            Авторизация = 2,
            Генерацияперсонажа = 3,
            Бой = 4,
          
          
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"{GAME.Регистрация} {(int)GAME.Регистрация}.");
            Console.WriteLine($"{GAME.Авторизация} {(int)GAME.Авторизация}.");
            Console.WriteLine($"{GAME.Генерацияперсонажа} {(int)GAME.Генерацияперсонажа}.");
            Console.WriteLine($"{GAME.Бой} {(int)GAME.Бой}.");
            string input = Console.ReadLine();
            GAME number = (GAME)int.Parse(input);
            Console.WriteLine($"Вы выбрали {number}.");
        }
    }
}
