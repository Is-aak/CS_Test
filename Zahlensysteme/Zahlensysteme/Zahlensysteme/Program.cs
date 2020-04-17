using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Programm zum Umwandeln von verschiedenen Zahlensysteme
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Titel("Dies ist ein Titel");

            Console.ReadKey();
        }


        static void Titel(string text)
        {
            int TxtLen = text.Length;
            Console.Clear();
            for (int i = 0; i < Console.WindowWidth; i++ )
            {
                Console.Write("-");
            }
            for (int i = 0; i < ( Console.WindowWidth - TxtLen) / 2; i++) 
            {
                Console.Write(" ");
            }
            Console.WriteLine(text);

            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("-");
            }
        }
        static string binaerEingabe() 
        {
            Console.WriteLine("Bitte eine Binärzahö eingeben");
            string input = Console.ReadLine();
            return input;
        }
    }
}
