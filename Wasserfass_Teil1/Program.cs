namespace Wasserfass_Teil1
{
    internal class Program
    {
        public class Wasserfass
        {
            private double MinimalPegel;
            private double MaximalPegel;
            private double Füllstand;
            private double Kapazität;

            public Wasserfass(double minimalPegel, double maximalPegel, double kapazität)
            {
                MinimalPegel = minimalPegel;
                MaximalPegel = maximalPegel;
                Kapazität = kapazität;
                Füllstand = minimalPegel;
            }

            public void befüllen(double menge)
            {
                if (Füllstand + menge <= Kapazität && Füllstand + menge <= MaximalPegel)
                {
                    Füllstand += menge;
                }
            }

            public void entnehmen(double menge)
            {
                if (Füllstand - menge >= MinimalPegel)
                {
                    Füllstand -= menge;
                }
            }

            public void entleeren()
            {
                Füllstand = MinimalPegel;
            }
        }
    }
    }
