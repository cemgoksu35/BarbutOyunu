using System;
using Barbut.Models;

namespace Barbut
{
    class Program
    {
        static void Main(string[] args)
        {
            Zar zar = new Zar();
            int sayi1 = zar.At();
            Console.WriteLine($"Zar 1 \n{zar.Yuz}");
            int sayi2 = zar.At();
            Console.WriteLine($"Zar 2 \n{zar.Yuz}");
            if (sayi1==sayi2)
            {
                Console.WriteLine("Berabere");
            }
            else if (sayi1>sayi2)
            {
                Console.WriteLine(sayi1 + " 1. zar kazandı " + sayi2);
                
            }
            else
            {
                Console.WriteLine(sayi2 + " 2. zar kazandı " + sayi1);
               
            }
        }
    }
}
