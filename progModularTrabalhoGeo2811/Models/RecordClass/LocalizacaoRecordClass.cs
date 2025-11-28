namespace progModularTrabalho2811.Models.RecordClass;

public record class LocalizacaoRecordClass(decimal Latitude, decimal Longitude)
{
    public LocalizacaoRecordClass MoverNorte(decimal v) => this with { Latitude = AdjLat(Latitude + v) };
    public LocalizacaoRecordClass MoverSul(decimal v) => this with { Latitude = AdjLat(Latitude - v) };
    public LocalizacaoRecordClass MoverLeste(decimal v) => this with { Longitude = AdjLon(Longitude + v) };
    public LocalizacaoRecordClass MoverOeste(decimal v) => this with { Longitude = AdjLon(Longitude - v) };

    private static decimal AdjLat(decimal lat)
    {
        if (lat > 90) return -90 + (lat - 90);
        if (lat < -90) return 90 + (lat + 90);
        return lat;
    }
    private static decimal AdjLon(decimal lon)
    {
        if (lon > 180) return lon - 360;
        if (lon < -180) return lon + 360;
        return lon;
    }
}
