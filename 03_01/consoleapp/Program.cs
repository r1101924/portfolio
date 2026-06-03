using System;
using System.Globalization;


Console.WriteLine("Opties");
Console.WriteLine("------");
Console.WriteLine("0. Oppervlakte rechthoek");
Console.WriteLine("1. Oppervlakte cirkel");
Console.WriteLine("2. Volume balk");
Console.WriteLine("3. Volume cilinder");
Console.WriteLine();

Console.Write("Geef een optie: ");
int optie = int.Parse(Console.ReadLine());

Console.WriteLine();

switch (optie)
{
    case 0:
        Console.Write("Geef een lengte: ");
        double l = double.Parse(Console.ReadLine());

        Console.Write("Geef een breedte: ");
        double b = double.Parse(Console.ReadLine());

        double oppR = MeetkundigeFormules.OppervlakteRechthoek(l, b);
        Console.WriteLine();
        Console.WriteLine($"De oppervlakte van de rechthoek is: {oppR} cm2");
        break;

    case 1:
        Console.Write("Geef een straal: ");
        double straal = double.Parse(Console.ReadLine());

        double oppC = MeetkundigeFormules.OppervlakteCirkel(straal);
        oppC = Math.Round(oppC, 1);

        Console.WriteLine();
        Console.WriteLine(
            $"De oppervlakte van de cirkel is: {oppC.ToString("0.0", new CultureInfo("nl-BE"))} cm²"
        );
        break;

    case 2:
        Console.Write("Geef een lengte: ");
        double lengte = double.Parse(Console.ReadLine());

        Console.Write("Geef een breedte: ");
        double breedte = double.Parse(Console.ReadLine());

        Console.Write("Geef een hoogte: ");
        double hoogte = double.Parse(Console.ReadLine());

        double volumeBalk = MeetkundigeFormules.VolumeBalk(lengte, breedte, hoogte);
        Console.WriteLine();
        Console.WriteLine($"De volume van de balk is: {volumeBalk} cm3");
        break;

    case 3:
        Console.Write("Geef een straal: ");
        double r = double.Parse(Console.ReadLine());

        Console.Write("Geef een hoogte: ");
        double h = double.Parse(Console.ReadLine());

        double volumeCil = MeetkundigeFormules.VolumeCilinder(r, h);
        volumeCil = Math.Round(volumeCil, 1);

        Console.WriteLine();
        Console.WriteLine(
            $"De volume van de cilinder is: {volumeCil.ToString("0.0", new CultureInfo("nl-BE"))} cm3"
        );
        break;
}

