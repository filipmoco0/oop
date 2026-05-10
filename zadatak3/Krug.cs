using System;

namespace Zadatak3;

public class Krug : IGeometrijskiLik, IUsporediPovrsinu<Krug>
{
    private float r;

    public string Boja { get; set; }

    public Krug(string boja, float r)
    {
        Boja = boja;
        this.r = r;
    }

    public void Tip()
    {
        Console.WriteLine("Krug polumjera " + r);
    }

    public float Povrsina()
    {
        return 3.14f * r * r;
    }

    public float Opseg()
    {
        return 2 * 3.14f * r;
    }

    public int UsporediPovrsinu(Krug tmp)
    {
        if (Povrsina() == tmp.Povrsina())
            return 0;
        else if (Povrsina() > tmp.Povrsina())
            return 1;
        else
            return 2;
    }
}
