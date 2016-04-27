CREATE TABLE cliente (
  cl_id INT IDENTITY(1,1) NOT NULL,
  cl_nome VARCHAR(100) NOT NULL,
  cl_datanascimento date NOT NULL, 
  cl_cpf VARCHAR(20) NOT NULL,
  cl_rg VARCHAR(20),
  cl_telefone VARCHAR(20) NOT NULL,
  cl_celular VARCHAR(20) NOT NULL,
  cl_telefone2 VARCHAR(20),
  cl_cep VARCHAR(20) NOT NULL,
  cl_endereco VARCHAR(100) NOT NULL,
  cl_numero VARCHAR(10) NOT NULL,
  cl_bairro VARCHAR(20) NOT NULL,
  cl_cidade VARCHAR(20) NOT NULL,
  cl_uf VARCHAR(3) NOT NULL,
  cl_email VARCHAR(30) NOT NULL,
  cl_nomepai VARCHAR(100) NOT NULL,
  cl_nomemae VARCHAR(100) NOT NULL,
  cl_profissao VARCHAR(50) NOT NULL,
  cl_observacoes VARCHAR(200) NOT NULL,
  	
	CONSTRAINT cliente_pk PRIMARY KEY (cl_id)
);

CREATE TABLE fornecedor(

  fr_id INT IDENTITY(1,1) NOT NULL,
  fr_razaosocial VARCHAR(100) NOT NULL,
  fr_inscricaoestadual VARCHAR(50) NOT NULL,
  fr_fantasia VARCHAR(50) NOT NULL,
  fr_endereco VARCHAR(100) NOT NULL,
  fr_cidade VARCHAR(50) NOT NULL,
  fr_uf VARCHAR(2) NOT NULL,
  fr_bairro VARCHAR(20) NOT NULL,
  fr_cep VARCHAR(10) NOT NULL,
  fr_contato VARCHAR(20) NOT NULL,
  fr_telefone VARCHAR(20) NOT NULL,
  fr_fax VARCHAR(20) NOT NULL,
  fr_email VARCHAR(50) NOT NULL,
  fr_nomerepresentante VARCHAR(50) NOT NULL,
  fr_telefonerepresentante VARCHAR(20) NOT NULL,
  fr_celularrepresentante VARCHAR(20) NOT NULL,
  fr_observacoes VARCHAR(200) NOT NULL,
  fr_cnpj VARCHAR(30) NOT NULL,

  CONSTRAINT fornecedor_pkey PRIMARY KEY (fr_id)
);

CREATE TABLE categoria(
 ct_id INT IDENTITY(1,1) NOT NULL,
 ct_nome VARCHAR(50) NOT NULL

 CONSTRAINT categoria_pkey PRIMARY KEY (ct_id)
);

CREATE TABLE produto (
  pr_id INT IDENTITY (1,1) NOT NULL,
  pr_descricao VARCHAR(50) NOT NULL,
  pr_unidade VARCHAR(3) NOT NULL,
  pr_grupo VARCHAR(20) NOT NULL,
  pr_grife VARCHAR(20) NOT NULL,
  pr_valor decimal (5,2) NOT NULL,
  pr_qtd INT NOT NULL,
  pr_estoqueminimo INT NOT NULL,
  ct_id INT,
  fr_id INT,

CONSTRAINT produto_pkey PRIMARY KEY(pr_id),
CONSTRAINT categoria_produto_fk FOREIGN KEY (ct_id) REFERENCES categoria (ct_id),
CONSTRAINT fornecedor_produto_fk FOREIGN KEY (fr_id) REFERENCES fornecedor (fr_id)
);

CREATE TABLE produtofornecedor(
  pf_qtd INT NOT NULL,
  pf_dtentrada VARCHAR(10) NOT NULL,
  pr_id INT NOT NULL,
  fr_id INT NOT NULL,
  pf_tipo VARCHAR(1),
  pf_observacoes VARCHAR(100),

  CONSTRAINT produtofornecedor_pkey PRIMARY KEY (fr_id, pr_id),
  CONSTRAINT produtofornecedor_fornecedor_fk FOREIGN KEY (fr_id) REFERENCES fornecedor (fr_id),
  CONSTRAINT produtofornecedor_produto_fk FOREIGN KEY (pr_id) REFERENCES produto (pr_id)
);

CREATE TABLE usuario(
  us_id INT IDENTITY(1,1) NOT NULL,
  us_senha VARCHAR NOT NULL,
  us_endereco VARCHAR NOT NULL,
  us_telefone VARCHAR NOT NULL,
  us_tipo VARCHAR NOT NULL,
  us_usuario VARCHAR NOT NULL,
  us_nome VARCHAR,
  CONSTRAINT usuario_pkey PRIMARY KEY (us_id)
);

CREATE TABLE venda(
  vn_id INT IDENTITY(1,1) NOT NULL,
  us_id INT NOT NULL,
  cl_id INT NOT NULL,
  vn_data date NOT NULL,
  vn_vlrtotal decimal (5,2) NOT NULL

  CONSTRAINT venda_pkey PRIMARY KEY(vn_id),
  CONSTRAINT usuario_venda_fk FOREIGN KEY (us_id) REFERENCES usuario (us_id),
  CONSTRAINT cliente_venda_fk FOREIGN KEY (cl_id) REFERENCES cliente (cl_id)

);

CREATE TABLE produtovenda(
  pv_dtsaida VARCHAR(10) NOT NULL,
  pv_qtd INT NOT NULL,
  pr_id INT NOT NULL,
  vn_id INT NOT NULL,

  CONSTRAINT produtovenda_pkey PRIMARY KEY (pr_id, vn_id),
  CONSTRAINT produtovenda_produto_fk FOREIGN KEY (pr_id) REFERENCES produto (pr_id),
  CONSTRAINT produtovenda_venda_fk FOREIGN KEY (vn_id) REFERENCES venda (vn_id)

);

CREATE TABLE receita(

  rc_id INT IDENTITY(1,1) NOT NULL,
  cl_id INT NOT NULL,
  vn_id INT NOT NULL,
  rc_historico VARCHAR(10) NOT NULL,
  rc_lodesferico DECIMAL(5,2),
  rc_loeesferico DECIMAL(5,2),
  rc_podesferico DECIMAL(5,2),
  rc_poeesferico DECIMAL(5,2),
  rc_lodcilindrico DECIMAL(5,2),
  rc_loecilindrico DECIMAL(5,2),
  rc_podcilindrico DECIMAL(5,2),
  rc_poecilindrico DECIMAL(5,2),
  rc_lodeixo DECIMAL(5,2),
  rc_loeeixo DECIMAL(5,2),
  rc_podeixo DECIMAL(5,2),
  rc_poeeixo DECIMAL(5,2),
  rc_lodaltura DECIMAL(5,2),
  rc_loealtura DECIMAL(5,2),
  rc_podaltura DECIMAL(5,2),
  rc_poealtura DECIMAL(5,2),
  rc_loddnp DECIMAL(5,2),
  rc_loednp DECIMAL(5,2),
  rc_poddnp DECIMAL(5,2),
  rc_poednp DECIMAL(5,2),
  rc_adicao DECIMAL(5,2),
  rc_nomemedico VARCHAR(20) NOT NULL,
  rc_observacoes VARCHAR(200) NOT NULL,
  rc_data date,
  rc_dtavencimento VARCHAR(10),

  CONSTRAINT receita_pkey PRIMARY KEY (rc_id),
  CONSTRAINT cliente_receita_fk FOREIGN KEY (cl_id) REFERENCES cliente (cl_id),
  CONSTRAINT venda_receita_fk FOREIGN KEY (vn_id) REFERENCES venda (vn_id)
);