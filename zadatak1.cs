using System;
using System.Collections.Generic;

namespace Zadatak1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> brojevi = new List<int>();

            Console.WriteLine("Unesite 7 cijelih brojeva:");

            while (brojevi.Count < 7)
            {
                try
                {
                    int broj = Convert.ToInt32(Console.ReadLine());
                    brojevi.Add(broj);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.WriteLine("\nLista prije uklanjanja:");

            for (int i = 0; i < brojevi.Count; i++)
            {
                if (i == brojevi.Count - 1)
                    Console.Write(brojevi[i]);
                else
                    Console.Write(brojevi[i] + ", ");
            }

            Console.WriteLine("\n\nUnesite broj za uklanjanje:");
            int zaUklanjanje = Convert.ToInt32(Console.ReadLine());

            brojevi.RemoveAll(x => x == zaUklanjanje);

            Console.WriteLine("\nLista nakon uklanjanja:");

            for (int i = 0; i < brojevi.Count; i++)
            {
                if (i == brojevi.Count - 1)
                    Console.Write(brojevi[i]);
                else
                    Console.Write(brojevi[i] + ", ");
            }

            Console.ReadKey();
        }
    }
}
