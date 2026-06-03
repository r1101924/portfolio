using System;

namespace consoleapp.Models;


public static class MeetkundigeFormules
{
    public static double OppervlakteRechthoek(double lengte, double breedte)
    {
        return lengte * breedte;
    }

    public static double OppervlakteCirkel(double straal)
    {
        return Math.PI * straal * straal;
    }

    public static double VolumeBalk(double lengte, double breedte, double hoogte)
    {
        return lengte * breedte * hoogte;
    }

    public static double VolumeCilinder(double straal, double hoogte)
    {
        return Math.PI * straal * straal * hoogte;
    }
}
