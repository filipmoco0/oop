using System;

namespace Zadatak4;

public class Uplata : ITransakcija, IUsporedba<Uplata>
{
    public string ID;
    public string datum;
    public string korisnik;
    public double iznos;

    public Uplata(string ID, string datum, string korisnik, double iznos)
    {
        this.ID = ID;
        this.datum = datum;
        this.korisnik = korisnik;
        this.iznos = iznos;
    }

    public void PrikaziTransakciju()
    {
        Console.WriteLine("UPLATA: " + ID + ", " + datum + ", " + korisnik + ", " + iznos);
    }

    public double VratiIznos()
    {
        return iznos;
    }

    public bool Jednako(Uplata tmp)
    {
        return korisnik == tmp.korisnik && iznos == tmp.iznos;
    }
}
