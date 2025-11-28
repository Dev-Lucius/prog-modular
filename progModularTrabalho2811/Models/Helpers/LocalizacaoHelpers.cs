namespace ProjetoLocalizacao.Models.Helpers;

public static class LocalizacaoHelpers
{
    public static void MoverNorte(ref decimal lat, decimal v)
    {
        lat += v; AdjLat(ref lat);
    }
    public static void MoverSul(ref decimal lat, decimal v)
    {
        lat -= v; AdjLat(ref lat);
    }
    public static void MoverLeste(ref decimal lon, decimal v)
    {
        lon += v; AdjLon(ref lon);
    }
    public static void MoverOeste(ref decimal lon, decimal v)
    {
        lon -= v; AdjLon(ref lon);
    }

    private static void AdjLat(ref decimal x)
    {
        if (x > 90) x = -90 + (x - 90);
        if (x < -90) x = 90 + (x + 90);
    }
    private static void AdjLon(ref decimal x)
    {
        if (x > 180) x -= 360;
        if (x < -180) x += 360;
    }
}
