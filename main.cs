using System;
using System.Collections.Generic;
using System.Linq;


namespace morseovka
{
    public class Morseovka
    {
        //ahoj
        //main se zeptá na to co chcete přeložit do morseovky a potom co chcete přeložiz z morseovky 
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
        //zakoduj je metoda pro přeložení textu do morseovky
        public static string zakoduj(string zkod)
        {

            var text = zkod;

            var m = string.Empty;
            //pro každé písmeno v textu zvolí string z dictionary morseovka a přidá ho do prázdného varu m
            foreach (var c in text)
            {
                m += morseovka[c] + " ";
            }
            //vrátí text v morseovce
            return m;

        }
        //dekoduj přeloží morseovku
        public static string Dekoduj(string mkod)
        {
            
            string[] mtext = mkod.Split("    ");
            //prázdný string do kterého se bude ukládat morseovka
            string prelozeno = "";
            //za každou větu v mtext
            foreach (string mvety in mtext)
            {
                //vety rozdělí na slovo bude je rozlišovat pomocí mezer
                string[] mslovo = mvety.Split(" ");
                string prelozenoslovo = "";
                //za každé písmeno ve slově přidá píšmeno z dictionary
                foreach (string mpismeno in mslovo)
                {
                    prelozenoslovo += morseovka.FirstOrDefault(x => x.Value == mpismeno).Key;
                    
                }

                prelozeno += (prelozeno == "") ? prelozenoslovo : " " + prelozenoslovo;

            }
            //vrátí preloženou morseovku
            return prelozeno;
        }
        //slovník pomocí kterého se vše překládá
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
