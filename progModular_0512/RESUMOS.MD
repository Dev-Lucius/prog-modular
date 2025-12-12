# RESUMOS — Programação Modular & Arquitetura de Software

> Anotações objetivas e didáticas sobre conceitos essenciais para turbinar seu aprendizado.

---

## Front-End

O **Front‑End** é a camada da aplicação responsável pela interface e pela interação com o usuário. Tudo aquilo que o usuário vê no navegador — páginas HTML, estilos (CSS) e lógica de apresentação (JavaScript) — pertence ao front‑end.

**O que faz:**

* Renderiza informações e captura ações do usuário (cliques, formulários).
* Valida entradas no cliente para melhorar a experiência.
* Solicita dados ao back‑end e os exibe de forma visual.

**Tecnologias comuns:** HTML, CSS, JavaScript, frameworks e bibliotecas (React, Vue, Angular, Svelte).

**Boas práticas:** separar apresentação da lógica, manter componentes pequenos e reutilizáveis, validar no cliente e no servidor.

---

## Back-End

O **Back‑End** é a parte da aplicação que roda no servidor e é responsável por regras de negócio, processamento, segurança e persistência de dados.

**O que faz:**

* Recebe requisições do front‑end, aplica regras de negócio e retorna respostas.
* Gerencia autenticação, autorização, validações e transações.
* Comunica‑se com o banco de dados e outros serviços.

**Tecnologias comuns:** C# (.NET), Node.js, Java, Python, Ruby; servidores, frameworks web, e ferramentas de orquestração.

**Boas práticas:** expor contratos claros (APIs), usar injeção de dependência, tratar erros consistentemente e manter baixa latência.

---

## Banco de Dados

O **banco de dados** armazena persistentemente as informações da aplicação. Pode ser relacional (SQL) ou não relacional (NoSQL), dependendo do tipo de dados e necessidades de consulta.

**Funções essenciais:**

* Persistência de entidades (usuários, pedidos, produtos).
* Consultas eficientes e integridade dos dados (constraints, transações).
* Suporte a backups e escalabilidade.

**Exemplos:** PostgreSQL, MySQL (relacionais); MongoDB, Redis (NoSQL/cache).

**Boas práticas:** normalização quando necessário, índices para consultas frequentes, backups regulares e isolamento de credenciais.

---

## Arquiteturas de Software

Arquitetura de Software é o conjunto de decisões de alto nível que define como os componentes do sistema se organizam e se comunicam.

**Princípios importantes:**

* **Separação de responsabilidades:** cada componente tem uma função clara.
* **Baixo acoplamento e alta coesão:** módulos independentes e internamente consistentes.
* **Escalabilidade e manutenção:** projetar pensando em crescimento e evolução.

**Padrões e estilos comuns:** camadas (layered), MVC, MVVM, Clean Architecture, Hexagonal (Ports & Adapters). A escolha depende do domínio, da equipe e dos requisitos de manutenção e desempenho.

---

## Arquitetura Cliente/Servidor

No modelo **Cliente/Servidor** há uma divisão clara: clientes (interfaces) solicitam serviços e servidores respondem processando e fornecendo dados.

**Elementos:**

* **Cliente:** navegador ou app que apresenta UI e faz requisições.
* **Servidor:** hospeda APIs, processa lógica e acessa o banco de dados.
* **Meio de comunicação:** normalmente HTTP/HTTPS.

**Vantagens:** separação de responsabilidades, escalabilidade e reutilização (vários clientes consomem o mesmo servidor).

---

## Comunicação através de Requisições e Respostas

A interação entre front‑end, back‑end e outros serviços acontece por **requisições e respostas**.

**Fluxo básico:**

1. Cliente envia uma requisição HTTP (GET, POST, PUT, DELETE) ao servidor.
2. Servidor processa a requisição (valida, executa regras, consulta o BD).
3. Servidor responde com um status HTTP e um corpo (geralmente JSON) contendo dados ou mensagens de erro.

**Boas práticas:**

* Use códigos de status HTTP corretos (200, 201, 400, 401, 404, 500).
* Padronize o formato das respostas (ex.: `{ status, data, error }`).
* Trate erros de forma explícita e segura; não exponha detalhes sensíveis.

---

## SPA — Single Page Application

Uma **SPA (Single Page Application)** carrega uma única página HTML inicial e, a partir dela, atualiza o conteúdo dinamicamente via JavaScript — sem recarregar toda a página.

**Características principais:**

* Navegação rápida e fluida após o carregamento inicial.
* Comunicação contínua com o back‑end via APIs (fetch/Ajax, GraphQL).
* Possibilidade de renderização no cliente (CSR) ou combinação com renderização no servidor (SSR) para SEO.

**Quando usar SPA:** aplicações interativas, dashboards, ferramentas com alto nível de interação do usuário.

**Desafios:** SEO, gerenciamento de estado, carregamento inicial e roteamento no cliente.

---

## Dicas de estudo rápidas

* Pratique implementando um CRUD completo: front‑end que consome uma API e persiste em um banco de dados.
* Observe o fluxo de uma requisição: do clique no botão até a resposta renderizada na UI.
* Compare um mesmo caso implementado como MPA e como SPA para entender vantagens e trade‑offs.
* Leia e implemente exemplos usando C# no back‑end (ASP.NET Core) e um framework JS no front‑end.

---

## Programação Orientada a Objetos (POO)

A **Programação Orientada a Objetos (POO)** é um paradigma que organiza o software em objetos — entidades que combinam **estado** (atributos) e **comportamento** (métodos). Em C# a POO é a base para estruturar sistemas modulares e manuteníveis.

**Conceitos-chave:**

* **Classe:** molde que define atributos e métodos (ex.: `Cliente`).
* **Objeto:** instância de uma classe (`new Cliente()`).
* **Encapsulamento:** esconder detalhes internos e expor apenas a interface necessária.
* **Herança:** permitir que uma classe derive propriedades e comportamentos de outra (reusar código).
* **Polimorfismo:** tratar objetos de diferentes classes através de uma interface comum (métodos sobrescritos/virtual).

**Benefícios para arquitetura:**

* Facilita a modelagem do domínio em entidades compreensíveis.
* Promove reutilização (herança/composição) e extensão (abertura para extensão, fechada para modificação).
* Melhora testabilidade com classes pequenas e com responsabilidades únicas.

**Boas práticas em C#:**

* Prefira **composição** a herança quando possível.
* Use **interfaces** para definir contratos e facilitar a injeção de dependência.
* Mantenha métodos curtos e classes com responsabilidade única (SRP).

---

## Programação Orientada a Eventos (POE)

A **Programação Orientada a Eventos** foca em responder a ocorrências (eventos) — como cliques, mensagens de rede ou timers — que disparam rotinas (handlers). Esse paradigma é amplamente usado no front‑end (JS) e em aplicações assíncronas no back‑end.

**Elementos principais:**

* **Event (evento):** ocorrência identificável (ex.: `onclick`, `messageReceived`).
* **Handler (manipulador):** função que reage quando o evento ocorre.
* **Emitter/Publisher:** componente que dispara eventos.
* **Subscriber:** componente que se inscreve para receber notificações.

**Exemplo (conceitual):**

* Usuário clica em um botão → evento `click` é emitido → handler valida dados e faz uma requisição ao servidor.

**Vantagens:**

* Desacoplamento entre emissor e consumidor (boa para arquiteturas escaláveis).
* Facilita programação assíncrona e reativa.
* Ótimo para aplicações com muitas interações e I/O (ex.: interfaces, mensageria).

**Desafios e cuidados:**

* Gerenciar o fluxo de eventos para evitar condições de corrida ou vazamento de handlers.
* Depurar fluxos assíncronos pode ser mais difícil; invista em logs e tracing.
* Em sistemas complexos, considerar arquiteturas orientadas a mensagens (MQ, pub/sub) para escalabilidade.

---