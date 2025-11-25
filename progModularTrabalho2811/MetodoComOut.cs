class IMC
{
    public double Altura { get; set; }
    public double Peso { get; set; }
    public double Valor { get; set; }
    public string Classificacao { get; set; }
}


static class ModuloIMC
{
    public static double CalcularIMC(out double altura, out double peso)
    {
        Console.Write("Altura (m): ");
        altura = double.Parse(Console.ReadLine());

        Console.Write("Peso (kg): ");
        peso = double.Parse(Console.ReadLine());

        return peso / Math.Pow(altura, 2);
    }

    public static void Classificar(ref IMC p)
    {
        if (p.Valor < 18.5)
            p.Classificacao = "Abaixo do peso";
        else if (p.Valor < 25)
            p.Classificacao = "Normal";
        else if (p.Valor < 30)
            p.Classificacao = "Sobrepeso";
        else
            p.Classificacao = "Obesidade";
    }
}


