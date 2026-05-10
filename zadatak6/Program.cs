using System;

namespace Zadatak6;

class Program
{
    static void Main(string[] args)
    {
        double iznos = 0;
        bool ispravno = false;

        while (!ispravno)
        {
            try
            {
                Console.WriteLine("Unesite iznos transakcije:");
                iznos = double.Parse(Console.ReadLine());

                if (iznos <= 0)
                {
                    throw new TransactionException("Iznos transakcije mora biti pozitivan.");
                }

                ispravno = true;
            }
            catch (TransactionException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        Console.WriteLine("Transakcija izvrsena. Iznos: " + iznos);

        Console.ReadKey();
    }
}
