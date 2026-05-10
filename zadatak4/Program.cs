using System;

namespace Zadatak4;

class Program
{
    static void Main(string[] args)
    {
        Uplata u1 = new Uplata("001", "1/1/2023", "Ivo Ivic", 100);
        Uplata u2 = new Uplata("002", "2/1/2023", "Ivo Ivic", 100);
        Uplata u3 = new Uplata("003", "3/1/2023", "Ana Anic", 200);

        Isplata i1 = new Isplata("004", "4/1/2023", "Marko Markic", 50);
        Isplata i2 = new Isplata("005", "5/1/2023", "Marko Markic", 50);
        Isplata i3 = new Isplata("006", "6/1/2023", "Ivan Ivic", 70);

        u1.PrikaziTransakciju();
        u2.PrikaziTransakciju();
        u3.PrikaziTransakciju();

        i1.PrikaziTransakciju();
        i2.PrikaziTransakciju();
        i3.PrikaziTransakciju();

        Console.WriteLine("u1 i u2 jednaki: " + u1.Jednako(u2));
        Console.WriteLine("u1 i u3 jednaki: " + u1.Jednako(u3));

        Console.WriteLine("i1 i i2 jednaki: " + i1.Jednako(i2));
        Console.WriteLine("i1 i i3 jednaki: " + i1.Jednako(i3));

        ITransakcija tr = new Uplata("007", "7/1/2023", "Pero Peric", 300);
        tr.PrikaziTransakciju();
        Console.WriteLine("Iznos: " + tr.VratiIznos());

        Console.WriteLine("Ako je objekt deklariran kao ITransakcija, ne moze se pozvati Jednako jer ta metoda nije u ITransakcija.");
    }
}
