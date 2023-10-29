using System;
using System.Collections.Generic;

public class Figur
{
    public float X { get; set; }
    public float Y { get; set; }

    public Figur(float x = 100.0f, float y = 100.0f)
    {
        X = x;
        Y = y;
    }

    public virtual void PrintPosition()
    {
        Console.WriteLine($"Position: [{X}, {Y}]");
    }

    public virtual void PrintArea()
    {
        Console.WriteLine("Fläche: Nicht verfügbar");
    }
}

public class Kreis : Figur
{
    public float Radius { get; set; }

    public Kreis(float radius, float x = 100.0f, float y = 100.0f) : base(x, y)
    {
        Radius = radius;
    }

    public override void PrintPosition()
    {
        Console.WriteLine($"Mittelpunkt: [{X}, {Y}]");
    }

    public override void PrintArea()
    {
        double flaeche = Math.PI * Radius * Radius;
        Console.WriteLine($"Fläche: {flaeche}");
    }
}

public class Rechteck : Figur
{
    public float Breite { get; set; }
    public float Hoehe { get; set; }

    public Rechteck(float breite, float hoehe, float x = 100.0f, float y = 100.0f) : base(x, y)
    {
        Breite = breite;
        Hoehe = hoehe;
    }

    public override void PrintArea()
    {
        float flaeche = Breite * Hoehe;
        Console.WriteLine($"Fläche: {flaeche}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Figur> figuren = new List<Figur>
        {
            new Kreis(10.0f, 50.0f, 50.0f),
            new Rechteck(20.0f, 30.0f, 150.0f, 150.0f)
        };

        foreach (var figur in figuren)
        {
            figur.PrintPosition();
            figur.PrintArea();
            Console.WriteLine();
        }
    }
}
