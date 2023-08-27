using System;



class MyMath
{
    // Diese Funktion berechnet den größten gemeinsamen Teiler
    public static int BerechneGGT(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }



    // Diese Funktion berechnet das kleinste gemeinsame Vielfache
    public static int BerechneKGV(int a, int b)
    {
        return (a * b) / BerechneGGT(a, b);
    }



    // Diese Funktion liest eine positive ganze Zahl ein
    public static int LesePositiveZahlEin(string nachricht)
    {
        int zahl;
        do
        {
            Console.Write(nachricht);
        } while (!int.TryParse(Console.ReadLine(), out zahl) || zahl <= 0);
        return zahl;
    }



    // Diese Funktion zeigt das Ergebnis an
    public static void ZeigeErgebnis(string typ, int a, int b, int ergebnis)
    {
        Console.WriteLine($"{typ} von {a} und {b} ist {ergebnis}");
    }
}



class Programm
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Bitte wähle eine Option:");
            Console.WriteLine("1. Größten gemeinsamen Teiler berechnen");
            Console.WriteLine("2. Kleinste gemeinsame Vielfache berechnen");
            Console.WriteLine("3. Beenden");



            int auswahl = MyMath.LesePositiveZahlEin("Deine Auswahl: ");



            if (auswahl == 3)
            {
                Console.WriteLine("Programm wird beendet.");
                break;
            }



            int num1 = MyMath.LesePositiveZahlEin("Gib die erste Zahl ein: ");
            int num2 = MyMath.LesePositiveZahlEin("Gib die zweite Zahl ein: ");



            switch (auswahl)
            {
                case 1:
                    int ggt = MyMath.BerechneGGT(num1, num2);
                    MyMath.ZeigeErgebnis("Größter gemeinsamer Teiler", num1, num2, ggt);
                    break;



                case 2:
                    int kgv = MyMath.BerechneKGV(num1, num2);
                    MyMath.ZeigeErgebnis("Kleinste gemeinsame Vielfache", num1, num2, kgv);
                    break;



                default:
                    Console.WriteLine("Ungültige Auswahl.");
                    break;
            }
        }
    }
}