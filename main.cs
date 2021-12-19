using System;
using System.Collections.Generic;
using System.Linq;


namespace morseovka
{
    public class Morseovka
    {

        static void Main(string[] args)
        {
            Console.WriteLine("write morse code you want to encode:  ");
            string prelozm = Console.ReadLine();
            prelozm = prelozm.ToLower();
            Console.WriteLine(zakoduj(prelozm));


            Console.WriteLine("write morse code you want to decode:  ");
            string preloz = Console.ReadLine();
            Console.WriteLine(Dekoduj(preloz));
        }
        public static string zakoduj(string zkod)
        {

            var text = zkod;

            var m = string.Empty;
            foreach (var c in text)
            {
                m += morseovka[c] + " ";
            }
            return m;

        }

        public static string Dekoduj(string mkod)
        {
            string[] mvety = mkod.Split("    ");
            string prelozeno = "";

            foreach (string mslovo in mvety)
            {
                string[] mpismena = mslovo.Split(" ");
                string prelozenoslovo = "";

                foreach (string mpismeno in mpismena)
                {
                    prelozenoslovo += morseovka.FirstOrDefault(x => x.Value == mpismeno).Key;
                    
                }

                prelozeno += (prelozeno == "") ? prelozenoslovo : " " + prelozenoslovo;

            }
            return prelozeno;
        }
        public static Dictionary<char, string> morseovka = new Dictionary<char, string>()
        {

             {' ' , "/"},
             {'a' , ".-"},
             {'b' , "-..."},
             {'c' , "-.-."},
             {'d' , "-.."},
             {'e' , "."},
             {'f' , "..-."},
             {'g' , "--."},
             {'h' , "...."},
             {'i' , ".."},
             {'j' , ".---"},
             {'k' , "-.-"},
             {'l' , ".-.."},
             {'m' , "--"},
             {'n' , "-."},
             {'o' , "---"},
             {'p' , ".--."},
             {'q' , "--.-"},
             {'r' , ".-."},
             {'s' , "..."},
             {'t' , "-"},
             {'u' , "..-"},
             {'v' , "...-"},
             {'w' , ".--"},
             {'x' , "-..-"},
             {'y' , "-.--"},
             {'z' , "--.."},
             {'0' , "-----"},
             {'1' , ".----"},
             {'2' , "..---"},
             {'3' , "...--"},
             {'4' , "....-"},
             {'5' , "....."},
             {'6' , "-...."},
             {'7' , "--..."},
             {'8' , "---.."},
             {'9' , "----."},
             {'?' , "..--.."},
             {';' , "-.-.-."},
             {'.' , ".-.-.-"},
             {',' , "--..--"},
             {'/' , "-..-."},
             {'=' , "-...-"},
             {'-' , "-....-"},
             {'(' , "-.--."},
             {')' , "-.--.-"},
             {'"' , ".-..-."},
             {':' , "---..."},
             {'_' , "..--.-"},
             {'+' , ".-.-."},
             {'@' , ".--.-."},
        };
    }
}
