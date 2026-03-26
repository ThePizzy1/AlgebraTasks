using System;
namespace Algebra1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intellisense
            //intelicode
            //Copilot Autocomplete

            //komentari 
            /*
             * komentari ctrl+k+c
             * odkomentiraj ctrl+k+u
             *  označi strelica+shift
             * k+f formatiranje
             *  k+e  ukloni nepotrebne using direktive
             */
            /*
             * VARIJABLE
             * ne smiju krenuti brojem ili rezerviranim riječima
             * mogu početi velikim slovom ili _
             * DEKLARACIJA: string ime;
             * TIPOVI PODATAKA:int(4byte), float(4byte), double(8byte), decimal(16byte)
             *  bool(1bit), char(2byta), string(2byte po znaku)
             *  unsigned:od 0 do x, samo pozitivni range
             *   short, long       
             *   constant varijable: jednom se deklariraju i inicijaliziraju i ne mijenjaju se
             
             */

            string name = "Iva";
            Console.WriteLine(name);

            //konkatinacija stringa
            Console.WriteLine("Ovo je " + name);
            Console.WriteLine('I');

            //formatiranje
            Console.WriteLine("Ime je {0}", name);

            //interpolacija stringa
            Console.BackgroundColor=ConsoleColor.Red;
            Console.WriteLine($"Po treći put ovo je {name}");

            Console.Write("Pozdrav, ");
            Console.Write(name);
            Console.Write("!");
            Console.ResetColor();
            int years = 22;

            System.Console.WriteLine("Pogodi tko je!");

            Console.BackgroundColor= ConsoleColor.Green;
            Console.WriteLine($"{name}! I imam {years} godine :)");
            Console.ResetColor();

            //eksplicitni sting i int
            //var ne možeš samo deklarirati moraš i inicijalizrati da kompajler zna koji je tip podatka
            var a = "100";//string
            var b = 200;//int
            var c =Int32.Parse(a) + b;
            var d = Convert.ToInt16(c);//short
            var e = Convert.ToInt64(c);//long
            Console.WriteLine($"Koliki je c? {c}");
            //FN+f5 i f10 za debagiranje
            //FN+F12     definicije 
            //debagiranji trabul shooting
            //Console.ReadLine();
        }
    }
}
