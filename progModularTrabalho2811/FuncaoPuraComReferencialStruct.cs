using System;

struct Disciplina
{
    public string Nome;
    public string Aluno;
    public int Media;
    public bool Passado;

    public Disciplina(string aluno, string nome, int media)
    {
        Aluno = aluno;
        Nome = nome;
        Media = media;
        Passado = false;
    }
}

static class ValidadorDisciplina
{
    public static bool DisciplinaPassada(ref Disciplina d)
    {
        if (d.Media >= 75)
        {
            d.Passado = true;
            Console.WriteLine($"Meus Parabéns {d.Aluno}! Você foi aprovado com média {d.Media} na disciplina de {d.Nome}.");
            return true;
        }

        d.Passado = false;
        Console.WriteLine($"Infelizmente {d.Aluno}, você não foi aprovado. Sua média de {d.Media} é insuficiente na disciplina de {d.Nome}.");
        return false;
    }
}
