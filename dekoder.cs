using System;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleApp3
{
    class dekoder
    {



        static void Main(string[] args)
        {
            Console.WriteLine(Dekoduj("-|  ...-|  ---|  .---|  .|    --|  .-|  --|  .-|    .-..|  --|  .-|  ---|    -..-|  -..|    -..-|  -..|    -..-|  -..|    .----|  ..---|  ...--|"));
            Console.WriteLine("Co chceš dekódovat?:");
            string preloz = Console.ReadLine();
            Console.WriteLine(Dekoduj(preloz));
        }

        public static string Dekoduj(string mkod) {
            string[] mvety = mkod.Split("    ");
            string prelozeno = "";

            foreach (string mslovo in mvety)
            {
                string[] mpismena = mslovo.Split("  ");
                string prelozenoslovo = "";

                foreach (string mpismeno in mpismena)
                {
                    prelozenoslovo += morseovka.FirstOrDefault(x => x.Value == mpismeno).Key;
                    // outputWord += MorseCode.Get(morseLetter); for codewars
                }

                prelozeno += (prelozeno == "") ? prelozenoslovo : " " + prelozenoslovo;

            }
            return prelozeno;
        }

        static Dictionary<char, string> morseovka = new Dictionary<char, string>(){

             
             {'a' , ".-|"},
             {'b' , "-...|"},
             {'c' , "-.-.|"},
             {'d' , "-..|"},
             {'e' , ".|"},
             {'f' , "..-.|"},
             {'g' , "--.|"},
             {'h' , "....|"},
             {'i' , "..|"},
             {'j' , ".---|"},
             {'k' , "-.-|"},
             {'l' , ".-..|"},
             {'m' , "--|"},
             {'n' , "-.|"},
             {'o' , "---|"},
             {'p' , ".--.|"},
             {'q' , "--.-|"},
             {'r' , ".-.|"},
             {'s' , "...|"},
             {'t' , "-|"},
             {'u' , "..-|"},
             {'v' , "...-|"},
             {'w' , ".--|"},
             {'x' , "-..-|"},
             {'y' , "-.--|"},
             {'z' , "--..|"},
             {'0' , "-----|"},
             {'1' , ".----|"},
             {'2' , "..---|"},
             {'3' , "...--|"},
             {'4' , "....-|"},
             {'5' , ".....|"},
             {'6' , "-....|"},
             {'7' , "--...|"},
             {'8' , "---..|"},
             {'9' , "----.|"},
        };
    }
}
