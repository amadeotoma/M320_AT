using System;

namespace Taschenrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+--------------------------------------+");
            Console.WriteLine("| 1. Addition                          |");
            Console.WriteLine("| 2. Subtraktion                       |");
            Console.WriteLine("| 3. Multiplikation                    |");
            Console.WriteLine("| 4. Division                          |");
            Console.WriteLine("| 5. Beenden                           |");
            Console.WriteLine("+--------------------------------------+");

            while (true)
            {
                int auswahl = HoleGanzeZahlEingabe("Welche Rechnung wollen Sie vornehmen? ");

                switch (auswahl)
                {
                    case 1:
                        DurchführenUndAnzeigen("Addition", Addiere);
                        break;
                    case 2:
                        DurchführenUndAnzeigen("Subtraktion", Subtrahiere);
                        break;
                    case 3:
                        DurchführenUndAnzeigen("Multiplikation", Multipliziere);
                        break;
                    case 4:
                        DurchführenUndAnzeigen("Division", Dividiere);
                        break;
                    case 5:
                        Console.WriteLine("Beenden...");
                        return;
                    default:
                        Console.WriteLine("Ungültige Auswahl");
                        break;
                }
            }
        }

        static int HoleGanzeZahlEingabe(string nachricht)
        {
            int eingabe;
            while (true)
            {
                Console.Write(nachricht);
                if (int.TryParse(Console.ReadLine(), out eingabe))
                {
                    return eingabe;
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine gültige ganze Zahl ein.");
                }
            }
        }

        static void DurchführenUndAnzeigen(string operation, Func<int, int, int> rechnung)
        {
            int num1 = HoleGanzeZahlEingabe("Geben Sie eine Zahl ein: ");
            int num2 = HoleGanzeZahlEingabe("Geben Sie eine weitere Zahl ein: ");
            int ergebnis = rechnung(num1, num2);
            Console.WriteLine($"{operation} Ergebnis: {ergebnis}");
        }

        static int Addiere(int a, int b)
        {
            return a + b;
        }

        static int Subtrahiere(int a, int b)
        {
            return a - b;
        }

        static int Multipliziere(int a, int b)
        {
            return a * b;
        }

        static int Dividiere(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Durch null kann nicht geteilt werden.");
                return 0;
            }
            return a / b;
        }
    }
}
