using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("napis faktorial:  ");
            int cislo = int.Parse(Console.ReadLine());
            int vysledek,a=0;
            vysledek = 1;
            for (int i = 1; i <= cislo; i++)
            {
                vysledek = vysledek * i;
            }
            Console.WriteLine(vysledek);
        }
    }
}
