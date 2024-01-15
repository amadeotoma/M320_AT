namespace Fussball
{
    public class Spieler
    {
        private int fitness; // 1 = tief, 2 = durchschnitt, 3 = hoch
        public string Name { get; private set; }
        public int JahresGehalt { get; private set; }
        
        public Spieler(string name, int jahresGehalt, int fitness, Erfahrung erfahrung)
        {
            Name = name;
            JahresGehalt = jahresGehalt;
            Fitness = fitness;
            Erfahrung = erfahrung;
        }

        public int Fitness {
            get => fitness;
            set {
                    if (value == 1) {fitness = 1;
                    }
                    if (value == 2) {fitness = 2;
                    }
                    if (value == 3) {fitness = 3;
                    }
                }
        }
        public Erfahrung Erfahrung { get; set; }
        public int MarktWert()
        {
            if (Fitness > 0)
            {
                if (Erfahrung > 0)
                {
                    return 200000 * Fitness * (int)Erfahrung;
                }
            }
            return 0;
        }
    }
}
