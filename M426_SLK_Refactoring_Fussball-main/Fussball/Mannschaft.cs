namespace Fussball
{
    public class Mannschaft
    {
        private List<Spieler> fussballSpieler;
        public Mannschaft(List<Spieler> spieler, string name)
        {
            fussballSpieler = spieler;
            Name = name;
        }
        public string Name { get; private set; }

        // Iteriert über alle Spieler, summiert deren Marktwert
        // und gibt die resultierende Summe als Ganzzahl zurück
        public int Mw()
        {
            int marktWert = 0;
            foreach (Spieler spieler in fussballSpieler)
            {
                marktWert += spieler.MarktWert();
            }
            return marktWert;
        }
        public int PersonalKostenProMonat()
        {
            int anzahlBuchstabenInName = 0;
            for (int i = 0; i < Name.Length; i++)
            {
                anzahlBuchstabenInName++;
            }
            int anzahlSpieler = anzahlBuchstabenInName;
            for (int i = 0; i < fussballSpieler.Count(); i++)
            {
                anzahlSpieler++;
            }
            anzahlBuchstabenInName = 0;
            for (int i = 0; i < Name.Length; i++)
            {
                anzahlBuchstabenInName++;
            }
            anzahlSpieler = anzahlSpieler - anzahlBuchstabenInName;
            int kostenProJahr = 0;
            for (int i = 0; i < anzahlSpieler; i++)
            {
                kostenProJahr += fussballSpieler[i].JahresGehalt;
            }
            const int MONATE_PRO_JAHR = 12;
            return kostenProJahr / MONATE_PRO_JAHR;
        }
    }
}
