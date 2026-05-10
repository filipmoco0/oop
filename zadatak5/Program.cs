using System;

namespace Zadatak5;

enum Mjeseci
{
    Sijecanj = 1,
    Veljaca,
    Ozujak,
    Travanj,
    Svibanj,
    Lipanj,
    Srpanj,
    Kolovoz,
    Rujan,
    Listopad,
    Studeni,
    Prosinac
}

class StringIznimka : Exception
{
    public StringIznimka(string poruka) : base(poruka)
    {
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] brojac = new int[13];

        Console.WriteLine("Izbornik mjeseci:");

        foreach (string mjesec in Enum.GetNames(typeof(Mjeseci)))
        {
            Console.WriteLine(mjesec);
        }

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Unesi broj mjeseca ili ESC za kraj:");

            ConsoleKeyInfo tipka = Console.ReadKey();
            Console.WriteLine();

            if (tipka.Key == ConsoleKey.Escape)
            {
                break;
            }

            string unos = tipka.KeyChar + Console.ReadLine();

            try
            {
                int broj;

                if (int.TryParse(unos, out broj))
                {
                    switch (broj)
                    {
                        case 1:
                            Console.WriteLine(Mjeseci.Sijecanj);
                            brojac[1]++;
                            break;
                        case 2:
                            Console.WriteLine(Mjeseci.Veljaca);
                            brojac[2]++;
                            break;
                        case 3:
                            Console.WriteLine(Mjeseci.Ozujak);
                            brojac[3]++;
                            break;
                        case 4:
                            Console.WriteLine(Mjeseci.Travanj);
                            brojac[4]++;
                            break;
                        case 5:
                            Console.WriteLine(Mjeseci.Svibanj);
                            brojac[5]++;
                            break;
                        case 6:
                            Console.WriteLine(Mjeseci.Lipanj);
                            brojac[6]++;
                            break;
                        case 7:
                            Console.WriteLine(Mjeseci.Srpanj);
                            brojac[7]++;
                            break;
                        case 8:
                            Console.WriteLine(Mjeseci.Kolovoz);
                            brojac[8]++;
                            break;
                        case 9:
                            Console.WriteLine(Mjeseci.Rujan);
                            brojac[9]++;
                            break;
                        case 10:
                            Console.WriteLine(Mjeseci.Listopad);
                            brojac[10]++;
                            break;
                        case 11:
                            Console.WriteLine(Mjeseci.Studeni);
                            brojac[11]++;
                            break;
                        case 12:
                            Console.WriteLine(Mjeseci.Prosinac);
                            brojac[12]++;
                            break;
                        default:
                            Console.WriteLine("Pogresan cijeli broj.");
                            brojac[0]++;
                            break;
                    }
                }
                else
                {
                    double realan;

                    if (double.TryParse(unos, out realan))
                    {
                        throw new Exception("Unesen je realan broj.");
                    }
                    else
                    {
                        throw new StringIznimka("Unesen je string.");
                    }
                }
            }
            catch (StringIznimka e)
            {
                Console.WriteLine(e.Message);

                Console.WriteLine("Broj unosa po mjesecima:");

                for (int i = 1; i <= 12; i++)
                {
                    Console.WriteLine((Mjeseci)i + ": " + brojac[i]);
                }

                Console.WriteLine("Broj pogresno unesenih cijelih brojeva: " + brojac[0]);
                break;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        Console.ReadKey();
    }
}
