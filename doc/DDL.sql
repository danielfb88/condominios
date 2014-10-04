CREATE TABLE endereco (
	id INT PRIMARY KEY,
	cidade VARCHAR,
	estado CHAR(2),
	cep VARCHAR,
	bairro VARCHAR,
	numero VARCHAR,
	Logradouro VARCHAR,
	complemento VARCHAR
);

CREATE TABLE condominio (
	id INT PRIMARY KEY,
	id_endereco INTEGER NOT NULL,
	qtd_apt INT,
	valor_agua REAL,
	valor_luz REAL,
	valor_gas REAL,
	nome VARCHAR
);
ALTER TABLE condominio ADD CONSTRAINT fk_condominio_endereco FOREIGN KEY (id_endereco) REFERENCES endereco (id);

CREATE TABLE funcionario (
	id INT PRIMARY KEY,
	id_endereco INTEGER NOT NULL,
	id_condominio INTEGER NOT NULL,
	nome VARCHAR,
	cpf VARCHAR,
	rg VARCHAR
);
ALTER TABLE funcionario ADD CONSTRAINT fk_funcionario_condominio FOREIGN KEY (id_condominio) REFERENCES condominio (id);
ALTER TABLE funcionario ADD CONSTRAINT fk_funcionario_endereco FOREIGN KEY (id_endereco) REFERENCES endereco (id);

CREATE TABLE sindico (
	id INT PRIMARY KEY,
	id_endereco INTEGER NOT NULL,
	id_condominio INTEGER NOT NULL,
	nome VARCHAR,
	cpf VARCHAR,
	rg VARCHAR
);
ALTER TABLE sindico ADD CONSTRAINT fk_sindico_endereco FOREIGN KEY (id_endereco) REFERENCES endereco (id);
ALTER TABLE sindico ADD CONSTRAINT fk_sindico_condominio FOREIGN KEY (id_condominio) REFERENCES condominio (id);

CREATE TABLE morador (
	id INT PRIMARY KEY,
	id_condominio INTEGER NOT NULL,
	nome VARCHAR,
	cpf VARCHAR,
	rg VARCHAR,
	numero_apt INT,
	adimplente INT
);
ALTER TABLE morador ADD CONSTRAINT fk_morador_condominio FOREIGN KEY (id_condominio) REFERENCES condominio (id);