using System;

namespace Zadatak3;

public class Kvadrat : Pravokutnik, IGeometrijskiLik
{
    public Kvadrat() : base(1, 1)
    {
    }

    public Kvadrat(float a) : base(a, a)
    {
    }

    public Kvadrat(string bo, float a) : base(bo, a, a)
    {
    }

    public void Tip()
    {
        Console.WriteLine("Kvadrat sa stranicom duljine " + _a);
    }

    public float Povrsina()
    {
        return _a * _a;
    }

    public float Opseg()
    {
        return 4 * _a;
    }
}
