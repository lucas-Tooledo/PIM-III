CREATE TABLE FORNECEDOR(
ID INT PRIMARY KEY,
DATA_REGISTRO DATE,
CONTATO_PRINCIPAL VARCHAR(100),
NOME_EMPRESA VARCHAR (100),
STATUS VARCHAR (50),
ESTADO CHAR(2),
CNPJ VARCHAR(20),
CEP VARCHAR(20),
CIDADE VARCHAR(100)
);

CREATE TABLE GERENTE(
ID INT PRIMARY KEY,
NOME VARCHAR(20),
CONTATO VARCHAR(20),
CPF VARCHAR(11),
STATUS VARCHAR(10)
);

CREATE TABLE FUNCIONARIO (
ID INT PRIMARY KEY,
NOME VARCHAR(20),
CONTATO VARCHAR(20),
CPF VARCHAR(11),
STATUS VARCHAR(10)
);

CREATE TABLE CLIENTE (
CODIGO INT PRIMARY KEY,
DATA_REGISTRO DATE,
CONTATO_PRINCIPAL VARCHAR(50),
NOME_EMPRESA VARCHAR (50),
STATUS VARCHAR(10),
ESTADO VARCHAR(2),
CNPJ VARCHAR (20),
CEP VARCHAR (20),
CIDADE VARCHAR (20),
CLASSIFICAÇÃO VARCHAR (20)
);

CREATE TABLE TAREFAS(
NOME VARCHAR(20),
PRAZO DATE,
PRIORIDADE VARCHAR(20),
ETAPA VARCHAR (20),
N_ETAPAS INT
);

CREATE TABLE PRODUÇÃO(
ID INT PRIMARY KEY,
DATAINICIO DATE,
PRAZO DATE,
QTD INT,
DATAFIM DATE,
PRIORIDADE VARCHAR (10),
NOMEPRODUTO VARCHAR (100),
ID_FORNECEDOR INT,
CODIGO_CLIENTE INT,
N_ETAPAS INT,
FOREIGN KEY (ID_FORNECEDOR)
REFERENCES FORNECEDOR(ID),
FOREIGN KEY (CODIGO_CLIENTE)
REFERENCES CLIENTE (CODIGO)
);

CREATE TABLE CREDENCIAIS (
EMAIL VARCHAR(50) PRIMARY KEY,
SENHA VARCHAR(100)
);
