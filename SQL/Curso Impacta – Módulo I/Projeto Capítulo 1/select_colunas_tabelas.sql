USE ECommerce;

-- Tabelas e suas chaves primárias
SELECT T.NAME AS TABELA
FROM SYSOBJECTS T 
WHERE T.xtype = 'U'

-- Colunas das tabelas do banco de dados
SELECT T.NAME AS TABELA, C.NAME AS COLUNAS
FROM SYSOBJECTS T JOIN SYSCOLUMNS C ON T.id = C.id
WHERE T.XTYPE = 'U' AND T.NAME = 'TB_CLIENTE'

-- Metadados das views
SELECT T.*
FROM SYSOBJECTS T 
WHERE T.xtype = 'V'

-- Mostrar também o tipo de cada coluna
SELECT T.NAME AS TABELA, C.NAME AS COLUNAS, C.xtype, DT.NAME
FROM SYSOBJECTS T JOIN SYSCOLUMNS C ON T.id = C.id
 JOIN SYSTYPES DT ON C.xtype = DT.xtype
WHERE T.XTYPE = 'U' AND T.name = 'TB_PEDIDO'