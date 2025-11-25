class Pessoa
{
    public string Nome { get; set; }
    public string Cpf  { get; set; }
}

static class Validador
{
    public static bool ValidadorCPF(string cpf)
    {
        if (cpf == null || cpf.Length != 11)
        {
            Console.WriteLine("CPF nulo.");
            return false;
        }

        // Remove caracteres não numéricos
        // "Where" é uma Clausula em LINQ - Language Integrated Query - e é usado para filtra elementos a partir
        // de uma base de Dados a partir de uma condição
        cpf = new string(cpf.Where(char.IsDigit).ToArray());

        
        // Verifica se todos os dígitos são iguais (CPF inválido)
        if (cpf.Distinct().Count() == 1)
        {
            Console.WriteLine("CPF inválido — todos os dígitos iguais.");
            return false;
        }

        // Validação matemática dos dígitos verificadores
        // Utilizando o Método "Select" do LINQ
        // Para cada caractere c na string cpf (ex.: '1', '2', etc.), ele
        // Cria uma Sequencia de Inteiros armazenados em um vetor
        int[] numeros = cpf.Select(c => int.Parse(c.ToString())).ToArray();

        // Primeiro dígito verificador
        int primeiroDigito = 0;
        int segundoDigito = 0;
        int soma = 0;
        for (int i = 0; i < 9; i++)
            soma += numeros[i] * (10 - i);

        if((soma % 11) < 2)
        {
            primeiroDigito = 0;
        } else
        {
            primeiroDigito = 11 - (soma % 11);
        }

        if (numeros[9] != primeiroDigito)
        {
            Console.WriteLine("CPF inválido — dígito verificador 1 incorreto.");
            return false;
        }

        // Segundo dígito verificador
        soma = 0;
        for (int i = 0; i < 10; i++)
            soma += numeros[i] * (11 - i);

        if((soma % 11) < 2)
        {
            segundoDigito = 0;
        } else
        {
            segundoDigito = 11 - (soma % 11);
        }

        if (numeros[10] != segundoDigito)
        {
            Console.WriteLine("CPF inválido — dígito verificador 2 incorreto.");
            return false;
        }

        Console.WriteLine("CPF válido!");
        return true;
    }
}
