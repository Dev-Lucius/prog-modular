// Dois Paradigmas de Programação
// Programação Orientadas a Objetos -> Cada Elemento da Página é um Objeto
// Programação Orientadas a Eventos -> Clicks, Tecla

var form = document.querySelector('form');

// "Adicionar um Ouvinte de Eventos"
form.addEventListener('submit', adicionar);

function adicionar(evento) {
    evento.preventDefault(); // Não Envia o Form

    var titulo = form.titulo.value;
    var genero = form.genero.value;
    var hype = form.hype.value;

    // JSON --> JavaScript Object Notation
    // Objeto != Classe
    // Classe Fornece uma Constrant à um Objeto
    // Constraint trata-se das Limitações das Regras de uma alguma coisa
    var filme = { // Objeto Literal !!
        // Chave e Valor do mesmo Valor
        titulo, 
        genero,
        hype
      };


    console.dir(filme);

      // ToDo: Enviar o Objeto para o Back-End

      // Porta do Back End
      var backend_url = 'http://localhost:5110/filme';

      var headers = new Headers();
      // Dizer que estamos enviando um JSON
      headers.append("Content-Type", "application/json");

      // Convertendo JSON em Texto para Enviar ao Back-End
      var body = JSON.stringify(filme);

      // fetch --> fazer requisições
      fetch(backend_url, {
        method: 'POST',
        body,
        headers
      });
    }