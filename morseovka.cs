using System;

namespace morseovka { 
    public static class Extensions
{
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

    public class Program
    {
      
        static void Main(string[] args)
        {
            string text="qwertzuiopasdfghjklyxcvbnm1234567890";
            int i = 0;
            string[] pole = new string[i];
            
            foreach (char pismeno in text)
            {

                


                
                if (pismeno.Equals('a')) { pole = pole.Append(".- a");}
                else if (pismeno.Equals('b')) { pole = pole.Append("-... b"); }
                else if (pismeno.Equals('c')) { pole = pole.Append("-.-. c"); }
                else if (pismeno.Equals('d')) { pole = pole.Append("-.. d"); }
                else if (pismeno.Equals('e')) { pole = pole.Append(". e"); }
                else if (pismeno.Equals('f')) { pole = pole.Append("..-. f"); }
                else if (pismeno.Equals('g')) { pole = pole.Append("--. g"); }
                else if (pismeno.Equals('h')) { pole = pole.Append(".... h"); }
                else if (pismeno.Equals('i')) { pole = pole.Append(".. i"); }
                else if (pismeno.Equals('j')) { pole = pole.Append(".--- j"); }
                else if (pismeno.Equals('k')) { pole = pole.Append("-.- k"); }
                else if (pismeno.Equals('l')) { pole = pole.Append(".-.. l"); }
                else if (pismeno.Equals('m')) { pole = pole.Append("-- m"); }
                else if (pismeno.Equals('n')) { pole = pole.Append("-. n"); }
                else if (pismeno.Equals('o')) { pole = pole.Append("--- o"); }
                else if (pismeno.Equals('p')) { pole = pole.Append(".--. p"); }
                else if (pismeno.Equals('q')) { pole = pole.Append("--.- q"); }
                else if (pismeno.Equals('r')) { pole = pole.Append(".-. r"); }
                else if (pismeno.Equals('s')) { pole = pole.Append("... s"); }
                else if (pismeno.Equals('t')) { pole = pole.Append("- t"); }
                else if (pismeno.Equals('u')) { pole = pole.Append("..- u"); }
                else if (pismeno.Equals('v')) { pole = pole.Append("...- v"); }
                else if (pismeno.Equals('w')) { pole = pole.Append(".-- w"); }
                else if (pismeno.Equals('x')) { pole = pole.Append("-..- x"); }
                else if (pismeno.Equals('y')) { pole = pole.Append("-.-- y"); }
                else if (pismeno.Equals('z')) { pole = pole.Append("--.. z"); }
                else if (pismeno.Equals('0')) { pole = pole.Append("----- 0"); }
                else if (pismeno.Equals('1')) { pole = pole.Append(".---- 1"); }
                else if (pismeno.Equals('2')) { pole = pole.Append("..--- 2"); }
                else if (pismeno.Equals('3')) { pole = pole.Append("...-- 3"); }
                else if (pismeno.Equals('4')) { pole = pole.Append("....- 4"); }
                else if (pismeno.Equals('5')) { pole = pole.Append("..... 5"); }
                else if (pismeno.Equals('6')) { pole = pole.Append("-.... 6"); }
                else if (pismeno.Equals('7')) { pole = pole.Append("--... 7"); }
                else if (pismeno.Equals('8')) { pole = pole.Append("---.. 8"); }
                else if (pismeno.Equals('9')) { pole = pole.Append("----. 9"); }
                else if (pismeno.Equals(' ')) { pole = pole.Append(" "); }

                

            }
            Console.WriteLine(string.Join(" ", pole));

            //dodelal jsem to v 00:45 doufam že dostanu zaplaceno pane CEO
        }
    }
}
