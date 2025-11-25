// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//  Atividade Avaliada 03: 
// Implementar usando métodos/funções em vários estilos, com class, struct, cópia e referência, com e sem return

// Função Impura
Pessoa p = new Pessoa();
p.Nome = "Luiz";
p.Cpf = "11111111111";

if (!(Validador.ValidadorCPF(p.Cpf)))
{
    Console.WriteLine(p.Nome + " Verifique seu CPF para Continuar seu Registro");
} else
{
    Console.WriteLine("Seja Bem Vindo " + p.Nome + ", seu CPF foi registrado com sucesso");
}

// FuncaoPuraComReferenciaStruct
Disciplina d = new Disciplina("Lucas", "Programação Modular", 79);
ValidadorDisciplina.DisciplinaPassada(ref d);
Console.WriteLine("Status Final: " + (d.Passado ? "Aprovado" : "Reprovado"));

// MetodoComOut
double Alt, Pes;
IMC pessoa = new IMC();
pessoa.Valor = ModuloIMC.CalcularIMC(out Alt, out Pes);
pessoa.Altura = Alt;
pessoa.Peso = Pes;

ModuloIMC.Classificar(ref pessoa);
Console.WriteLine($"\nIMC: {pessoa.Valor:F2} - {pessoa.Classificacao}");


// Função sem Return
DateTime day = new DateTime(); 
TimeOnly hour = new TimeOnly();

FuncaoSemReturn.DiaHoje(ref day, ref hour);
Console.WriteLine("Data: " + day);
Console.WriteLine("Hora: " + hour);