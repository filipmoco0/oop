using System;
using System.Collections.Generic;

namespace Zadatak3;

class Program
{
    static void Main(string[] args)
    {
        IGeometrijskiLik p1 = new Pravokutnik("Crvena", 2.5f, 4);
        IGeometrijskiLik kv1 = new Kvadrat("Zuta", 5);
        IGeometrijskiLik kv2 = new Kvadrat();

        List<IGeometrijskiLik> geom_likovi = new List<IGeometrijskiLik>() { p1, kv1, kv2 };

        Console.WriteLine("Lista geometrijskih likova:");

        foreach (IGeometrijskiLik g in geom_likovi)
        {
            g.Tip();

            if (g.Opseg() <= 0 || g.Povrsina() <= 0)
            {
                Console.WriteLine("Geometrijski lik nije dobro definiran!");
                Console.WriteLine("Boja: " + g.Boja);
            }
            else
            {
                Console.WriteLine("Opseg: " + g.Opseg());
                Console.WriteLine("Povrsina: " + g.Povrsina());
                Console.WriteLine("Boja: " + g.Boja);
            }

            Console.WriteLine();
        }

        IGeometrijskiLik najveci = geom_likovi[0];

        foreach (IGeometrijskiLik g in geom_likovi)
        {
            if (g.Opseg() > 0 && g.Povrsina() > 0)
            {
                IUsporediPovrsinu<IGeometrijskiLik> usporedba =
                    (IUsporediPovrsinu<IGeometrijskiLik>)najveci;

                if (usporedba.UsporediPovrsinu(g) == 2)
                {
                    najveci = g;
                }
            }
        }

        Console.WriteLine("Najveca povrsina je: " + najveci.Povrsina());
        Console.WriteLine("Likovi s najvecom povrsinom:");

        foreach (IGeometrijskiLik g in geom_likovi)
        {
            if (g.Povrsina() == najveci.Povrsina())
            {
                g.Tip();
                Console.WriteLine("Povrsina: " + g.Povrsina());
            }
        }

        Console.WriteLine();
        Console.WriteLine("Usporedba samo krugova:");

        List<Krug> krugovi = new List<Krug>()
        {
            new Krug("Crvena", 3),
            new Krug("Plava", 5),
            new Krug("Zelena", 2)
        };

        Krug najveciKrug = krugovi[0];

        foreach (Krug k in krugovi)
        {
            if (najveciKrug.UsporediPovrsinu(k) == 2)
            {
                najveciKrug = k;
            }
        }

        Console.WriteLine("Najveci krug:");
        najveciKrug.Tip();
        Console.WriteLine("Povrsina: " + najveciKrug.Povrsina());
    }
}
