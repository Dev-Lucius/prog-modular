using System;

// Importando todos os tipos
using ProjetoLocalizacao.Models.Class;
using ProjetoLocalizacao.Models.Struct;
using ProjetoLocalizacao.Models.RecordClass;
using ProjetoLocalizacao.Models.RecordStruct;
using ProjetoLocalizacao.Models.Helpers;

class Program
{
    static void Main()
    {
        Console.WriteLine("==== TESTE COMPLETO DO SISTEMA DE LOCALIZAÇÃO ====\n");

        // ============================
        // 1. Classe Mutável
        // ============================
        var locClass = new LocalizacaoClass(10, 20);
        locClass.MoverNorte(15);
        locClass.MoverOeste(50);
        Console.WriteLine($"LocalizacaoClass: {locClass}");

        // ============================
        // 2. Struct Mutável
        // ============================
        var locStruct = new LocalizacaoStruct(10, 20);
        locStruct.MoverSul(25);
        locStruct.MoverLeste(200);
        Console.WriteLine($"LocalizacaoStruct: ({locStruct.Latitude}, {locStruct.Longitude})");

        // ============================
        // 3. Record Class Imutável
        // ============================
        var locRecordClass = new LocalizacaoRecordClass(0, 0);
        locRecordClass = locRecordClass.MoverNorte(120);
        Console.WriteLine($"LocalizacaoRecordClass: {locRecordClass}");

        // ============================
        // 4. Record Struct Mutável
        // ============================
        var locRecordStruct = new LocalizacaoRecordStruct(45, 45);
        locRecordStruct.MoverSul(200);
        Console.WriteLine($"LocalizacaoRecordStruct: ({locRecordStruct.Latitude}, {locRecordStruct.Longitude})");

        // ============================
        // 5. Helpers (por referência)
        // ============================
        decimal lat = 80;
        decimal lon = 170;

        LocalizacaoHelpers.MoverNorte(ref lat, 30);
        LocalizacaoHelpers.MoverLeste(ref lon, 50);

        Console.WriteLine($"Helpers: ({lat}, {lon})");

        Console.WriteLine("\n==== FIM DOS TESTES ====");
    }
}
