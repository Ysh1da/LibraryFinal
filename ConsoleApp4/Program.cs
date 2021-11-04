using System;
using Main;

namespace ConsoleApp

{
    class Program
    {


        static void Main(string[] args)
        {
            

            Console.WriteLine("First Player name");
            string readName = Console.ReadLine();
            Console.WriteLine("HP");
            int readHealth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Damage");
            int readDamage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kevlar");
            int readArmour = Convert.ToInt32(Console.ReadLine());
            Character FirstPlayer = new Character(readName, readHealth, readDamage, readArmour);
            Console.WriteLine(FirstPlayer.ToString());
    
            Console.WriteLine("First Player name");
            readName = Console.ReadLine();
            Console.WriteLine("HP");
            readHealth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Damage");
            readDamage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kevlar");
            readArmour = Convert.ToInt32(Console.ReadLine());
            Character SecondPlayer = new Character(readName, readHealth, readDamage, readArmour);
            Console.WriteLine(SecondPlayer.ToString());
            
        }
    }
}
