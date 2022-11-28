using System;

namespace lab1ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Se citesc doua numere de la tastatura, x si y. Scrieti un program care va verifica
            daca x este divizibil cu y.
                * In cazul in care x este divizibil cu y, programul va afisa “divizibil” iar in caz contrar,
                “indivizibil”. */
            Console.WriteLine("Write two numbers and I`ll check if one is divisible with the other one.");
            Console.WriteLine("Write your first number");

            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Write your second number");
            int b = int.Parse(Console.ReadLine());

            if (a % b == 0)
            {
                Console.WriteLine("Divisible");
            }
            else
            {
                Console.WriteLine("Indivisible");
            }
        }
    }
}
