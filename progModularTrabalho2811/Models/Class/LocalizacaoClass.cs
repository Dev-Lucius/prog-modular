namespace ProjetoLocalizacao.Models.Class;

public class LocalizacaoClass
{
    public decimal Latitude { get; private set; }
    public decimal Longitude { get; private set; }

    public LocalizacaoClass(decimal latitude, decimal longitude)
    {
        Latitude = latitude;
        Longitude = longitude;
        AjustarLimites();
    }

    public void MoverNorte(decimal valor) { Latitude += valor; AjustarLimites(); }
    public void MoverSul(decimal valor) { Latitude -= valor; AjustarLimites(); }
    public void MoverLeste(decimal valor) { Longitude += valor; AjustarLimites(); }
    public void MoverOeste(decimal valor) { Longitude -= valor; AjustarLimites(); }

    private void AjustarLimites()
    {
        if (Latitude > 90) Latitude = -90 + (Latitude - 90);
        if (Latitude < -90) Latitude = 90 + (Latitude + 90);
        if (Longitude > 180) Longitude -= 360;
        if (Longitude < -180) Longitude += 360;
    }

    public override string ToString() => $"({Latitude}, {Longitude})";
}
