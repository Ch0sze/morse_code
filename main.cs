using System;

namespace morseovka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Morse code");
            //smyčka pro případné opakovaní funkce
            int ret = 1;
            while (ret == 1)
            {
                Console.Write("Press 1 if you want to encode ot press 2 if you want to decode:  ");
            again:
                //zde se program zeptá, co chcete aby dělal
                int num = Convert.ToInt32(Console.ReadLine());
                //jesti že chcete spustit encode spustí se tenhle if:
                if (num == 1)
                {
                    //spusteni encode 
                    encoder mors = new encoder();
                    mors.StartEncode();
                }
                //nebo jesti chcete spustit decode spustí se tenhle elseif:
                else if (num == 2)
                {
                    //spusteni decode programu
                    decoder mors = new decoder();
                    mors.StartDecode();
                }
                //jinak vypíše chybné zapsání čísla a pošle uživatele zpátky na začátek programu
                else
                {
                    Console.WriteLine("you entered wrong number:{0}", num);
                    goto again;
                }
                //jestli že chce uživatel znovu použít program napíše 1
                Console.Write("press 1 if you want another en/decode, otherwise press 2:  ");
                ret = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
