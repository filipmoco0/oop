using System;

namespace Zadatak4;

public class Isplata : ITransakcija, IUsporedba<Isplata>
{
    public string ID;
    public string datum;
    public string korisnik;
    public double iznos;

    public Isplata(string ID, string datum, string korisnik, double iznos)
    {
        this.ID = ID;
        this.datum = datum;
        this.korisnik = korisnik;
        this.iznos = iznos;
    }

    public void PrikaziTransakciju()
    {
        Console.WriteLine("ISPLATA: " + ID + ", " + datum + ", " + korisnik + ", " + iznos);
    }

    public double VratiIznos()
    {
        return iznos;
    }

    public bool Jednako(Isplata tmp)
    {
        return korisnik == tmp.korisnik && iznos == tmp.iznos;
    }
}
