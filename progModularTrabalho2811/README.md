# 📍 Sistema de Localizações em C#

### Movimentação Geográfica com Classes, Structs e Referências

Este projeto implementa um conjunto de estruturas e classes em **C#**
para representar uma localização geográfica (latitude e longitude) e
fornecer métodos capazes de mover essa localização para **Norte, Sul,
Leste e Oeste**, respeitando limites geográficos e realizando
**wrap-around** quando necessário.

O objetivo do trabalho é demonstrar diferentes formas de implementar
lógica semelhante usando:

-   **class**
-   **record class**
-   **struct**
-   **record struct**
-   Métodos que **alteram por valor**, **por referência** e **com
    retorno**

------------------------------------------------------------------------

## 📌 Funcionalidades

### ✔ Representação da Localização

Cada localização possui: - **Latitude** (entre -90 e 90) - **Longitude**
(entre -180 e 180)

### ✔ Movimentação

Existem métodos para mover: - Norte → aumenta a latitude\
- Sul → diminui a latitude\
- Leste → aumenta a longitude\
- Oeste → diminui a longitude

### ✔ Regras Importantes

1.  Se ultrapassar os limites, ocorre **wrap-around**:
    -   Latitude 95 → -85\
    -   Longitude 200 → -160
2.  Métodos implementados em diferentes versões:
    -   Com retorno
    -   Sem retorno
    -   Mudando por cópia
    -   Mudando por referência

------------------------------------------------------------------------

## 📂 Estrutura do Projeto

    /ProjetoLocalizacao
    │
    ├── Program.cs
    ├── Localizacoes.cs
    └── README.md

------------------------------------------------------------------------

## 🧱 Tipos Implementados

### 1️⃣ **LocalizacaoClass**

-   Classe tradicional
-   Métodos que alteram o próprio objeto
-   Métodos com retorno de novo objeto

### 2️⃣ **LocalizacaoRecordClass**

-   Semelhante a classe, porém:
    -   Imutabilidade estrutural
    -   Métodos retornam novas instâncias

### 3️⃣ **LocalizacaoStruct**

-   Struct mutável
-   Métodos alteram por cópia

### 4️⃣ **LocalizacaoRecordStruct**

-   Struct com benefícios de record:
    -   Igualdade por valor
    -   Pode ser mutável ou imutável

### 5️⃣ **Funções Externas (static helpers)**

-   Recebem por **ref**
-   Recebem **por valor**
-   Retornam novo valor

------------------------------------------------------------------------

## 🛠 Lógica de Wrap-Around

### Latitude

-   Valores acima de +90 → refletem para o negativo\
-   Valores abaixo de -90 → refletem para o positivo

Exemplo:

    latitude = 92 → -88
    latitude = -100 → 80

### Longitude

-   Utiliza rotação circular simples:

```{=html}
<!-- -->
```
    Se > 180 → longitude -= 360
    Se < -180 → longitude += 360

Exemplo:

    long = 200 → -160
    long = -250 → 110

------------------------------------------------------------------------

## 🧪 Testes Implementados (Program.cs)

O arquivo `Program.cs` contém **5 testes para cada tipo de
implementação**, incluindo:

### ✔ Testes para classe

-   Movimentar Norte\
-   Movimentar Sul ultrapassando limite\
-   Movimentar Leste com wrap-around\
-   Movimentar Oeste com limite negativo\
-   Sequência de movimentos

### ✔ Testes para record class

-   Retorno imutável\
-   Verificação de igualdade\
-   Sequência de transformações

### ✔ Testes para struct

-   Teste do comportamento por valor\
-   Necessidade de reassinar resultado

### ✔ Testes para record struct

-   Teste de comparação por valor\
-   Movimentos sucessivos

### ✔ Testes para funções externas

-   Passagem por referência usando `ref`\
-   Passagem por valor\
-   Verificação de preservação da cópia

------------------------------------------------------------------------

## 📘 Exemplo de Saída do Programa

    === Testes com Classe ===
    Inicial: (0,0)
    Após mover Norte 10.5 → (10.5, 0)
    Após mover Sul 200 → ( -90 → wrap → 90 )
    Após mover Leste 300 → (90, -60)
    ...

    === Testes com Struct ===
    Inicial: (5,5)
    Struct após mover Leste 200 → (-155)
    (Requer reassinatura pois struct não altera por referência)
    ...

------------------------------------------------------------------------

## 📎 Pontos Didáticos do Trabalho

Este trabalho demonstra:

### 🟦 Diferenças entre class e struct

-   **class**: referência\
-   **struct**: valor

### 🟩 Comportamento de record

-   Igualdade estrutural
-   Uso ideal para objetos imutáveis

### 🟥 Modificação por referência

-   `ref` permite alterar argumentos diretamente
-   Evita cópia desnecessária

### 🟨 Regras matemáticas de geolocalização

-   Wrap-around\
-   Limites de latitude\
-   Rotação de longitude

------------------------------------------------------------------------

## 📚 Tecnologias Utilizadas

-   **C# 12**
-   .NET 8 SDK
-   Programação orientada a objetos
-   Tipos por valor e referência
-   Testes manuais no `Program.cs`

------------------------------------------------------------------------

## 🧾 Como Executar

1.  Certifique-se de ter o .NET 8 instalado:

```{=html}
<!-- -->
```
    dotnet --version

2.  Compile e execute:

```{=html}
<!-- -->
```
    dotnet run

------------------------------------------------------------------------

## 📜 Licença

Este projeto é de uso educacional para fins de estudo e prática de
programação.
