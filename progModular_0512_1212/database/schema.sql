-- schema --> Esquema
-- Definição da Estrutura Organizacional de um Banco
-- DDL ==> Data Definition Language

DROP DATABASE IF EXISTS tadsflix;
CREATE DATABASE tadsflix;
\c tadsflix;


DROP TABLE IF EXISTS filmes;

-- Tabelas são Coleções, logo são sempre PLURAIS
-- (de preferência)
CREATE TABLE IF NOT EXISTS filmes(
    titulo text DEFAULT 'Sem Título',
    genero text DEFAULT NULL,
    hype INTEGER DEFAULT 2.5,
    assistido BOOLEAN DEFAULT FALSE
);

INSERT INTO filmes VALUES 
('Velozes e Furiosos 9', 'ACAO', 4, FALSE)