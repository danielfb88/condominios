CREATE TABLE endereco (
	id SERIAL PRIMARY KEY,
	cidade VARCHAR NOT NULL,
	estado CHAR(2) NOT NULL,
	cep VARCHAR NOT NULL,
	bairro VARCHAR NOT NULL,
	numero VARCHAR,
	Logradouro VARCHAR,
	complemento VARCHAR
);

CREATE TABLE condominio (
	id SERIAL PRIMARY KEY,
	id_endereco INTEGER NOT NULL,
	qtd_apt INT NOT NULL,
	valor_agua REAL,
	valor_luz REAL,
	valor_gas REAL
);
ALTER TABLE condominio ADD CONSTRAINT fk_condominio_endereco FOREIGN KEY (id_endereco) REFERENCES endereco (id);

CREATE TABLE funcionario (
	id SERIAL PRIMARY KEY,
	id_endereco INTEGER NOT NULL,
	id_condominio INTEGER NOT NULL,
	nome VARCHAR NOT NULL,
	cpf VARCHAR NOT NULL,
	rg VARCHAR
);
ALTER TABLE funcionario ADD CONSTRAINT fk_funcionario_condominio FOREIGN KEY (id_condominio) REFERENCES condominio (id);
ALTER TABLE funcionario ADD CONSTRAINT fk_funcionario_endereco FOREIGN KEY (id_endereco) REFERENCES endereco (id);

CREATE TABLE sindico (
	id SERIAL PRIMARY KEY,
	id_endereco INTEGER NOT NULL,
	id_condominio INTEGER NOT NULL,
	nome VARCHAR NOT NULL,
	cpf VARCHAR NOT NULL,
	rg VARCHAR NOT NULL
);
ALTER TABLE sindico ADD CONSTRAINT fk_sindico_endereco FOREIGN KEY (id_endereco) REFERENCES endereco (id);
ALTER TABLE sindico ADD CONSTRAINT fk_sindico_condominio FOREIGN KEY (id_condominio) REFERENCES condominio (id);

CREATE TABLE morador (
	id SERIAL PRIMARY KEY,
	id_condominio INTEGER NOT NULL,
	nome VARCHAR NOT NULL,
	cpf VARCHAR NOT NULL,
	rg VARCHAR NOT NULL,
	numero_apt INT
);
ALTER TABLE morador ADD CONSTRAINT fk_morador_condominio FOREIGN KEY (id_condominio) REFERENCES condominio (id);