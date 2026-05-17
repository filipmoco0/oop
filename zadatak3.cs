using System;
using System.Collections.Generic;
using System.Collections;

namespace Zadatak2
{
    class Student
    {
        private string _ime;
        private string _prezime;
        private string _jmbag;
        private SortedList<string, int> _ocjene;

        public string Ime
        {
            get { return _ime; }
        }

        public string Prezime
        {
            get { return _prezime; }
        }

        public string JMBAG
        {
            get { return _jmbag; }
        }

        public SortedList<string, int> Ocjene
        {
            get { return _ocjene; }
        }

        public Student(string ime, string prezime, string jmbag,
            SortedList<string, int> ocjene)
        {
            _ime = ime;
            _prezime = prezime;
            _jmbag = jmbag;
            _ocjene = ocjene;
        }

        public void AzurirajOcjenu(string ID_predmeta, int ocjena)
        {
            if (ocjena < 1 || ocjena > 5)
            {
                Console.WriteLine("Neispravna ocjena!");
                return;
            }

            if (_ocjene.ContainsKey(ID_predmeta))
            {
                _ocjene[ID_predmeta] = ocjena;
            }
            else
            {
                Console.WriteLine($"{_ime} {_prezime} ({_jmbag}) nema predmet {ID_predmeta}");
            }
        }

        public void NoviPredmet(
            SortedList<string, string> predmeti,
            string ID_predmeta,
            int ocjena)
        {
            if (string.IsNullOrWhiteSpace(ID_predmeta))
            {
                Console.WriteLine("Neispravan ID predmeta!");
                return;
            }

            if (ocjena < 1 || ocjena > 5)
            {
                Console.WriteLine("Neispravna ocjena!");
                return;
            }

            if (_ocjene.ContainsKey(ID_predmeta))
            {
                Console.WriteLine("Predmet je već upisan!");
                return;
            }

            if (predmeti.ContainsKey(ID_predmeta))
            {
                _ocjene.Add(ID_predmeta, ocjena);
            }
            else
            {
                Console.WriteLine("Predmet ne postoji!");
            }
        }

        public void Ispis(SortedList<string, string> predmeti)
        {
            Console.WriteLine($"{_ime} {_prezime} ({_jmbag}):");

            foreach (KeyValuePair<string, int> o in _ocjene)
            {
                Console.WriteLine($"{o.Key} - {predmeti[o.Key]}: {o.Value}");
            }

            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, string> predmeti =
                new SortedList<string, string>();

            predmeti.Add("OOP", "Objektno orijentirano programiranje");
            predmeti.Add("MAT", "Matematika");
            predmeti.Add("OP", "Osnove programiranja");

            SortedList<string, int> ocjene1 =
                new SortedList<string, int>();

            ocjene1.Add("OOP", 5);
            ocjene1.Add("MAT", 4);

            SortedList<string, int> ocjene2 =
                new SortedList<string, int>();

            ocjene2.Add("OP", 3);
            ocjene2.Add("MAT", 5);

            SortedList<string, int> ocjene3 =
                new SortedList<string, int>();

            ocjene3.Add("OOP", 2);

            Student s1 = new Student("Ivan", "Ivic", "001", ocjene1);
            Student s2 = new Student("Ana", "Anic", "002", ocjene2);
            Student s3 = new Student("Marko", "Maric", "003", ocjene3);

            List<Student> studenti = new List<Student>();

            studenti.Add(s1);
            studenti.Add(s2);
            studenti.Add(s3);

            Console.WriteLine("ISPIS STUDENATA\n");

            foreach (Student s in studenti)
            {
                s.Ispis(predmeti);
            }

            Console.WriteLine("AZURIRANJE OCJENE\n");

            s1.AzurirajOcjenu("MAT", 5);
            s1.Ispis(predmeti);

            Console.WriteLine("DODAVANJE NOVOG PREDMETA\n");

            s3.NoviPredmet(predmeti, "MAT", 4);
            s3.Ispis(predmeti);

            Console.ReadKey();
        }
    }
}
