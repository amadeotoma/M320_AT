using System;
using System.Collections.Generic;

class Fussballmannschaft
{
    public List<Feldspieler> FeldspielerList { get; private set; }
    public Torwart Torwart { get; private set; }

    public Fussballmannschaft(Torwart torwart, List<Feldspieler> feldspielerList)
    {
        Torwart = torwart;
        FeldspielerList = feldspielerList;
    }

    public int Spielzug()
    {
        int erzielteTore = 0;
        foreach (var spieler in FeldspielerList)
        {
            erzielteTore += spieler.AufsTorSchiessen();
            erzielteTore += spieler.Graetschen();
            erzielteTore += spieler.Dribbeln();
        }

        erzielteTore += Torwart.SchussHalten();
        erzielteTore += Torwart.Abstoss();

        return erzielteTore;
    }
}

class Torwart
{
    public string Name { get; private set; }

    public Torwart(string name)
    {
        Name = name;
    }

    public int SchussHalten()
    {
        int erzielteTore = new Random().Next(0);
        Console.WriteLine($"{Name} hält den Schuss vom Gegner!");
        return erzielteTore;
    }

    public int Abstoss()
    {
        int erzielteTore = new Random().Next(0);
        Console.WriteLine($"{Name} macht einen Abstoss!");
        return erzielteTore;
    }
}

class Feldspieler
{
    public string Name { get; private set; }

    public Feldspieler(string name)
    {
        Name = name;
    }

    public int AufsTorSchiessen()
    {
        int erzielteTore = new Random().Next(0, 5);
        Console.WriteLine($"{Name} schiesst {erzielteTore} Mal aufs Tor!");
        return erzielteTore;
    }

    public int Graetschen()
    {
        int erzielteTore = new Random().Next(0);
        Console.WriteLine($"{Name} macht eine Blutgrätsche!");
        return erzielteTore;
    }

    public int Dribbeln()
    {
        int erzielteTore = new Random().Next(0);
        Console.WriteLine($"{Name} dribbelt den Gegner schwindelig!");
        return erzielteTore;
    }
}

class Spiel
{
    public Fussballmannschaft RealMadrid { get; private set; }
    public Fussballmannschaft Barcelona { get; private set; }

    public Spiel(Fussballmannschaft realmadrid, Fussballmannschaft barcelona)
    {
        RealMadrid = realmadrid;
        Barcelona = barcelona;
    }

    public string Spielen()
    {
        int realTore = RealMadrid.Spielzug();
        int barcaTore = Barcelona.Spielzug();

        if (realTore > barcaTore)
        {
            return $"RealMadrid gewinnt mit {realTore}:{barcaTore}";
        }
        else if (realTore < barcaTore)
        {
            return $"Barcelona gewinnt mit {barcaTore}:{realTore}";
        }
        else
        {
            return $"Match endet Unentschieden mit {realTore}:{barcaTore}";
        }
    }
}

class Program
{
    static void Main()
    {
        Torwart torwart1 = new Torwart("Casillas");
        List<Feldspieler> feldspielerList1 = new List<Feldspieler>
        {
            new Feldspieler("Ronaldo"),
        };

        Torwart torwart2 = new Torwart("TerStegen");
        List<Feldspieler> feldspielerList2 = new List<Feldspieler>
        {
            new Feldspieler("Messi"),
        };

        Fussballmannschaft heimMannschaft = new Fussballmannschaft(torwart1, feldspielerList1);
        Fussballmannschaft gastMannschaft = new Fussballmannschaft(torwart2, feldspielerList2);

        Spiel spiel = new Spiel(heimMannschaft, gastMannschaft);
        string ergebnis = spiel.Spielen();

        Console.WriteLine(ergebnis);
    }
}
