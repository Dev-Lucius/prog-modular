namespace progModularTrabalho2811.Models.Struct;

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
        // Ajuste correto para ultrapassar os polos
        if (Latitude > 90)
        {
            Latitude = 180 - Latitude;
            Longitude += 180;
        }
        else if (Latitude < -90)
        {
            Latitude = -180 - Latitude;
            Longitude += 180;
        }

        // Normaliza longitude para ficar entre -180 e 180
        while (Longitude > 180)
            Longitude -= 360;

        while (Longitude < -180)
            Longitude += 360;
    }

    public override string ToString()
    {
        return $"Lat: {Latitude}, Long: {Longitude}";
    }
}
