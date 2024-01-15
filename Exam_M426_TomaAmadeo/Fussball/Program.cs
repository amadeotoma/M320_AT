using System.Globalization;
namespace Fussball
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Spieler> spielerFcsg = new List<Spieler>
            {
                new Spieler("Zigi", 100000, 3, Erfahrung.Hoch),
                new Spieler("Görtler", 80000, 3, Erfahrung.Durchschnitt),
                new Spieler("Sutter", 90000, 3, Erfahrung.Hoch),
                new Spieler("Schubert", 75000, 2, Erfahrung.Durchschnitt),
                new Spieler("Geubbels", 80000, 2, Erfahrung.Tief),
                new Spieler("Fazliji", 76000, 3, Erfahrung.Tief),
                new Spieler("Stevanovic", 88000, 3, Erfahrung.Durchschnitt),
                new Spieler("Quintilla", 79000, 3, Erfahrung.Hoch),
                new Spieler("Diaby", 55000, 1, Erfahrung.Tief),
                new Spieler("Möller", 40000, 2, Erfahrung.Hoch),
                new Spieler("Lüchinger", 110000, 2, Erfahrung.Hoch)
            };

            // Wird verwendet, um den Betrag in Schweizer Franken zu formatieren
            CultureInfo swissCulture = new CultureInfo("de-ch");

            Mannschaft fcsg = new Mannschaft(spielerFcsg, "FC St.Gallen");
            Console.WriteLine($"Mannschaft: {fcsg.Name}");
            Console.WriteLine($"Marktwert: {fcsg.Mw().ToString("C", swissCulture)}");
            Console.WriteLine($"Personalkosten im Monat: {fcsg.PersonalKostenProMonat().ToString("C", swissCulture)}");
        }
    }
}