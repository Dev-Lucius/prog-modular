-- schema --> Esquema
-- Definição da Estrutura Organizacional de um Banco
-- DDL ==> Data Definition Language

DROP DATABASE IF EXISTS tadsfilmes;
CREATE DATABASE tadsfilmes;
\c tadsfilmes;

-- É uma constraint
CREATE TYPE GENERO AS ENUM ('DRAMA', 'COMEDIA', 'ACAO');

DROP TABLE IF EXISTS filmes;

-- Tabelas são Coleções, logo são sempre PLURAIS
-- (de preferência)
CREATE TABLE IF NOT EXISTS filmes(
    titulo text DEFAULT 'Sem Título',
    genero GENERO DEFAULT NULL,
    hype INTEGER DEFAULT 2.5,
    assisitido BOOLEAN DEFAULT FALSE
);

INSERT INTO filmes VALUES 
('Velozes e Furiosos 9', 'ACAO', 4, FALSE)