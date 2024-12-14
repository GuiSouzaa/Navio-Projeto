select * from Fornecedor;
select * from Navio;
select * from Produtos;
select * from Ajustes;

INSERT INTO Fornecedor (
ID_FORNECEDOR, 
REFERENCIA_ID, 
NOME_FORNECEDOR, 
NOME_CONTATO, 
FONE_ZAP, 
EMAIL) VALUES ('f800',
 'REF001', 
 'Fornecedor Guilherme', 
 'Contato A', 
 '123456789', 
 'guilherme@exemplo.com');

INSERT INTO Navio (
    ID_NAVIO,
    NOME_NAVIO, 
    PORTO, 
    MODAL
) VALUES (
    1,
    'Navio grandiosa', 
    'Porto santos', 
    'Modal longo curso'
);

INSERT INTO Produtos (
    ID_PRODUTO, 
    ID_FORNECEDOR, 
    Id_Tabela, 
    NOME_TABELA, 
    REFERENCIA, 
    FANTASIA, 
    DESC_PRODUTO, 
    CAR_PRODUTO, 
    PESO_CAIXA, 
    PALLET_EURO, 
    PALLET_PBR
) VALUES (
    101,  -- ID_PRODUTO
    'f800',  -- ID_FORNECEDOR
    10,  -- Id_Tabela
    'Tabela cruzeiro',  -- NOME_TABELA
    'REF001',  -- REFERENCIA
    'SIRI',  -- FANTASIA
    'Carne de siri',  -- DESC_PRODUTO
    'Crab meat 10kg box',  -- CAR_PRODUTO
    20,  -- PESO_CAIXA
    50,  -- PALLET_EURO
    70  -- PALLET_PBR
);

INSERT INTO Ajustes (
    ID_PRODUTO,
    ID_FORNECEDOR,
    ID_NAVIO
) VALUES (
    101, -- ID_PRODUTO (relacionando com o produto inserido)
    'f800', -- ID_FORNECEDOR (relacionando com o fornecedor inserido)
    1 -- ID_NAVIO (relacionando com o navio inserido)
);

INSERT INTO Preco_Venda ( -- Ainda dando algum erro, verificar.
    ID_PRODUTO,
    PRECO
) VALUES (
    101, -- ID_PRODUTO (relacionando com o produto inserido)
    43.50 -- PRECO (valor do preço de venda)
);

