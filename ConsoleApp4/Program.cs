using System;
using Main;

namespace ConsoleApp

{
    class Program
    {


        static void Main(string[] args)
        {
            Character FirstPlayer = new Character("???", 0, 0, 0);
            Character SecondPlayer = new Character("??!", 0, 0, 0);

            Console.WriteLine("Задайте имя первому персонажу");
            string ReadName = Console.ReadLine();
            Console.WriteLine("Укажите hp персонажа");
            int ReadHealth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Укажите dmg персонажа");
            int ReadDamage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Укажите arm персонажа");
            int ReadArmour = Convert.ToInt32(Console.ReadLine());
            FirstPlayer = new Character(ReadName, ReadHealth, ReadDamage, ReadArmour);
            FirstPlayer.ToString();

            Console.WriteLine("Задайте имя второму персонажу");
            ReadName = Console.ReadLine();
            Console.WriteLine("Укажите hp персонажа");
            ReadHealth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Укажите dmg персонажа");
            ReadDamage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Укажите arm персонажа");
            ReadArmour = Convert.ToInt32(Console.ReadLine());
            SecondPlayer = new Character(ReadName, ReadHealth, ReadDamage, ReadArmour);
            SecondPlayer.ToString();

            Character.Fight(FirstPlayer, SecondPlayer);
            if (Character.Fight(FirstPlayer, SecondPlayer) == true)
            {
                Console.WriteLine($"Выиграл игрок {FirstPlayer.Name}");
            }
            else
            {
                Console.WriteLine($"Выиграл игрок {SecondPlayer.Name}");
            }
        }
    }
}