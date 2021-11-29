using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Morse code");
            Console.Write("Press 1 if you want to decode ot press 2 if you want to encode:  ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 1)
            {
                //spusteni decode programu
            }
            else if (num == 2)
            {
                //spusteni encode programu
            }
            else
            {
                Console.WriteLine("you entered wrong number:{0},num");
            }
        }
    }
}
