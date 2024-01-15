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

        public int Mw()
        {
            int marktWert = 0;
            foreach (Spieler spieler in fussballSpieler)
            {
                marktWert += spieler.MarktWert();
            }
            return marktWert;
        }
        public int MonatsKostenPersonal()
        {
            int BuchstabenInName = 0;
            for (int i = 0; i < Name.Length; i++)
            {
                BuchstabenInName++;
            }
            int anzahlSpieler = BuchstabenInName;
            for (int i = 0; i < fussballSpieler.Count(); i++)
            {
                anzahlSpieler++;
            }
            BuchstabenInName = 0;
            for (int i = 0; i < Name.Length; i++)
            {
                BuchstabenInName++;
            }
            anzahlSpieler = anzahlSpieler - BuchstabenInName;
            int kostenProJahr = 0;
            for (int i = 0; i < anzahlSpieler; i++)
            {
                kostenProJahr += fussballSpieler[i].JahresGehalt;
            }
            const int AnzahlMonate = 12;
            return kostenProJahr / AnzahlMonate;
        }
    }
}
