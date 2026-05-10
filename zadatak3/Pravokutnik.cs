using System;

namespace Zadatak3;

public class Pravokutnik : IGeometrijskiLik, IUsporediPovrsinu<IGeometrijskiLik>
{
    protected float _a, _b;

    public string Boja { get; set; }

    public Pravokutnik()
    {
        _a = 0;
        _b = 0;
        Boja = "Zelena";
    }

    public Pravokutnik(float a, float b)
    {
        _a = a;
        _b = b;
        Boja = "Zelena";
    }

    public Pravokutnik(string bo, float a, float b)
    {
        Boja = bo;
        _a = a;
        _b = b;
    }

    public void Tip()
    {
        Console.WriteLine("Pravokutnik sa stranicama duljine " + _a + " i " + _b);
    }

    public float Povrsina()
    {
        return _a * _b;
    }

    public float Opseg()
    {
        return 2 * _a + 2 * _b;
    }

    public int UsporediPovrsinu(IGeometrijskiLik tmp)
    {
        if (Povrsina() == tmp.Povrsina())
            return 0;
        else if (Povrsina() > tmp.Povrsina())
            return 1;
        else
            return 2;
    }
}
