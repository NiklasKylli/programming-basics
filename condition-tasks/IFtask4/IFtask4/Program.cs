using System;

namespace IFtask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma lajittelee 3 lukua nousevaan järjestykseen");
            Console.Write("Syötä 1. luku: ");
            string userInput = Console.ReadLine();
            int x = int.Parse(userInput);



            Console.Write("Syötä 2. luku: ");
            userInput = Console.ReadLine();
            int y = int.Parse(userInput);

            Console.Write("Syötä 3. luku: ");
            userInput = Console.ReadLine();
            int z = int.Parse(userInput);

            
            Console.WriteLine($"syötit luvut {x} - {y} - {z}");

            
            
        }
    }
}