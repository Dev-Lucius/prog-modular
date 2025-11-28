namespace ProjetoLocalizacao.Models.Struct;

public struct LocalizacaoStruct
{
    public decimal Latitude { get; private set; }
    public decimal Longitude { get; private set; }

    public LocalizacaoStruct(decimal latitude, decimal longitude)
    {
        Latitude = latitude;
        Longitude = longitude;
        Ajustar();
    }

    public void MoverNorte(decimal v) { Latitude += v; Ajustar(); }
    public void MoverSul(decimal v) { Latitude -= v; Ajustar(); }
    public void MoverLeste(decimal v) { Longitude += v; Ajustar(); }
    public void MoverOeste(decimal v) { Longitude -= v; Ajustar(); }

    private void Ajustar()
    {
        if (Latitude > 90) Latitude = -90 + (Latitude - 90);
        if (Latitude < -90) Latitude = 90 + (Latitude + 90);
        if (Longitude > 180) Longitude -= 360;
        if (Longitude < -180) Longitude += 360;
    }
}
