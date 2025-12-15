
using backend.Models;
using Microsoft.AspNetCore.Mvc;
using Npgsql;

namespace backend.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{   
    // Vira um Filme do  Front-End
    // Tratar os Possíveis Erros
    [HttpPost]
    public ActionResult Post([FromBody] Filme filme)
    {
        if (filme.Hype < 1 || filme.Hype > 5)
        {
            return BadRequest("hype inválido");
        }
        Console.WriteLine("Filme Recebido");
        Console.WriteLine(filme);

        // ==== Inicio do Banco ====
        // Endereço e Credenciais do PostgresSQL
        var StrConexao = "Host=localhost;Port=5432;Username=postgres;Password=postgres;Database=tadsflix";

        var sql = "INSERT INTO FILMES (titulo, genero, hype, assistido) VALUES (@titulo, @genero, @hype, true)";

        // Conecta ao Banco
        using var Conexao = new NpgsqlConnection(StrConexao);
        Conexao.Open();

        // Dados do Insert 
        var cmd = new NpgsqlCommand(sql, Conexao);
        cmd.Parameters.AddWithValue("@titulo", filme.Titulo);
        cmd.Parameters.AddWithValue("@genero", filme.Genero);
        cmd.Parameters.AddWithValue("@hype", filme.Hype);

        cmd.ExecuteNonQuery(); // Submete o Comando ao Banco

        // ==== Fim do banco ====

        // Insert
        return Ok("Filme Salvo Com Sucesso");
    }



    [HttpGet]
    public string Get()
    {
        return "análise e Desenvolvimento de Sistemas";
        
    }
}
