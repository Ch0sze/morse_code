using System;

namespace morseovka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Morse code");
            Console.Write("Press 1 if you want to encode ot press 2 if you want to decode:  ");
        again:
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 1)
            {
                //spusteni encode 
                encoder mors = new encoder();
                mors.StartEncode();
            }
            else if (num == 2)
            {
                //spusteni decode programu
                decoder mors = new decoder();
                mors.StartDecode();
            }
            else
            {
                Console.WriteLine("you entered wrong number:{0}", num);
                goto again;
            }
        }
    }
}