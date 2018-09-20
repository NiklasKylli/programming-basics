﻿using System;

namespace IFTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma selvittää onko luku pariton vai parillinen");
            Console.Write("Syötä numero: ");

            string userInput = Console.ReadLine();
            int number = 0;
            bool isNumber = int.TryParse(userInput, out number);

            if (isNumber)
            {
                if (number % 2 == 0)
                    Console.WriteLine($"Luku {number} on parillinen.");
                else
                    Console.WriteLine($"Luku {number} on pariton.");
            }
            else
                Console.WriteLine("Väärä syöte!");
        }
    }
}