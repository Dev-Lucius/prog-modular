namespace progModularTrabalho2811.Models.RecordStruct;

public record struct LocalizacaoRecordStruct(decimal Latitude, decimal Longitude)
{
    public void MoverNorte(decimal v)
    {
        Latitude += v;
        Ajustar();
    }

    public void MoverSul(decimal v)
    {
        Latitude -= v;
        Ajustar();
    }

    public void MoverLeste(decimal v)
    {
        Longitude += v;
        Ajustar();
    }

    public void MoverOeste(decimal v)
    {
        Longitude -= v;
        Ajustar();
    }

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

        // Normalizar longitude entre -180 e 180
        while (Longitude > 180)
            Longitude -= 360;

        while (Longitude < -180)
            Longitude += 360;
    }
}
