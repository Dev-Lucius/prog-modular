namespace ProjetoLocalizacao.Models.RecordStruct;

public record struct LocalizacaoRecordStruct(decimal Latitude, decimal Longitude)
{
    public void MoverNorte(decimal v) => Latitude = AdjLat(Latitude + v);
    public void MoverSul(decimal v) => Latitude = AdjLat(Latitude - v);
    public void MoverLeste(decimal v) => Longitude = AdjLon(Longitude + v);
    public void MoverOeste(decimal v) => Longitude = AdjLon(Longitude - v);

    private static decimal AdjLat(decimal x)
    {
        if (x > 90) return -90 + (x - 90);
        if (x < -90) return 90 + (x + 90);
        return x;
    }
    private static decimal AdjLon(decimal x)
    {
        if (x > 180) return x - 360;
        if (x < -180) return x + 360;
        return x;
    }
}
