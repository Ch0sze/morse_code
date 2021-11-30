using System;

namespace morseovka { 
    // moc to mu nechápu ale snad to nějak vysvětlím
    // tohle přidá do pole další string takže jsem to potřeboval aby se to napsalo na jednom řádku nevím jak jinak bych to udělal
    public static class Extensions
{   // tohle dělá novej append příkaz kterej vezme existující pole přidá velikost pole +1 a hodnotu v závorce
    public static T[] Append<T>(this T[] array, T item)
    {
        if (array == null)
        {
            return new T[] { item };
        }
        T[] result = new T[array.Length + 1];
        array.CopyTo(result, 0);
        result[array.Length] = item;
        return result;
    }
}
    // tohle je ta morseova abeceda
    public class Program
    {
      
        static void Main(string[] args)
        {
            //text co se má přeložit
            string text="QWE";
            //pole do kterého se dá prelozený text
            string[] pole = new string[0];
            //převede všechny písmena na malé, kdyby byly velké tak to nepřeloží
            String preloz = text.ToLower();
            //pro každé písmeno v preloz dej do pole pismeno v morseovce
            foreach (char pismeno in preloz)
            {




                //morseova abeceda
                //když pismeno je rovno pismenu v equals(pismeno) dej do pole pole=pole.Append(prelozene pismeno)((nebo čislo))
                if (pismeno.Equals('a')) { pole = pole.Append(".-| "); }
                else if (pismeno.Equals('b')) { pole = pole.Append("-...| "); }
                else if (pismeno.Equals('c')) { pole = pole.Append("-.-.| "); }
                else if (pismeno.Equals('d')) { pole = pole.Append("-..| "); }
                else if (pismeno.Equals('e')) { pole = pole.Append(".| "); }
                else if (pismeno.Equals('f')) { pole = pole.Append("..-.| "); }
                else if (pismeno.Equals('g')) { pole = pole.Append("--.| "); }
                else if (pismeno.Equals('h')) { pole = pole.Append("....| "); }
                else if (pismeno.Equals('i')) { pole = pole.Append("..| "); }
                else if (pismeno.Equals('j')) { pole = pole.Append(".---| "); }
                else if (pismeno.Equals('k')) { pole = pole.Append("-.-| "); }
                else if (pismeno.Equals('l')) { pole = pole.Append(".-..| "); }
                else if (pismeno.Equals('m')) { pole = pole.Append("--| "); }
                else if (pismeno.Equals('n')) { pole = pole.Append("-.| "); }
                else if (pismeno.Equals('o')) { pole = pole.Append("---| "); }
                else if (pismeno.Equals('p')) { pole = pole.Append(".--.| "); }
                else if (pismeno.Equals('q')) { pole = pole.Append("--.-| "); }
                else if (pismeno.Equals('r')) { pole = pole.Append(".-.| "); }
                else if (pismeno.Equals('s')) { pole = pole.Append("...| "); }
                else if (pismeno.Equals('t')) { pole = pole.Append("-| "); }
                else if (pismeno.Equals('u')) { pole = pole.Append("..-| "); }
                else if (pismeno.Equals('v')) { pole = pole.Append("...-| "); }
                else if (pismeno.Equals('w')) { pole = pole.Append(".--| "); }
                else if (pismeno.Equals('x')) { pole = pole.Append("-..-| "); }
                else if (pismeno.Equals('y')) { pole = pole.Append("-.--| "); }
                else if (pismeno.Equals('z')) { pole = pole.Append("--..| "); }
                else if (pismeno.Equals('0')) { pole = pole.Append("-----| "); }
                else if (pismeno.Equals('1')) { pole = pole.Append(".----| "); }
                else if (pismeno.Equals('2')) { pole = pole.Append("..---| "); }
                else if (pismeno.Equals('3')) { pole = pole.Append("...--| "); }
                else if (pismeno.Equals('4')) { pole = pole.Append("....-| "); }
                else if (pismeno.Equals('5')) { pole = pole.Append(".....| "); }
                else if (pismeno.Equals('6')) { pole = pole.Append("-....| "); }
                else if (pismeno.Equals('7')) { pole = pole.Append("--...| "); }
                else if (pismeno.Equals('8')) { pole = pole.Append("---..| "); }
                else if (pismeno.Equals('9')) { pole = pole.Append("----.| "); }
                else if (pismeno.Equals(' ')) { pole = pole.Append(" "); }



            }
            //vypiš všechny hodnoty v poli
            Console.WriteLine(string.Join(" ", pole));

            //dodelal jsem to v 00:45 doufam že dostanu zaplaceno pane CEO
        }
    }
}
