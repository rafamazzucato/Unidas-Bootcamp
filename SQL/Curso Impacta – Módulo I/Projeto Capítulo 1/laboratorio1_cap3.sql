USE ECommerce;

SELECT
	Id,
	Descricao,
	Preco,
	PrecoVenda,
	(PrecoVenda - Preco) AS MargemLucro
FROM
	Produto

SELECT
	P.Id,
	P.Descricao,
	(P.Preco * E.Quantidade) as TotalInvestido
FROM Produto AS P
JOIN Estoque AS E
	ON P.Id = E.IdProduto

SELECT
	SUM((P.Preco * E.Quantidade)) as TotalInvestido
FROM Produto AS P
JOIN Estoque AS E
	ON P.Id = E.IdProduto
	
SELECT
	P.Id,
	P.Descricao,
	P.Preco,
	P.PrecoVenda,
	E.Quantidade * (PrecoVenda - Preco) as LucroEstimado
FROM
	Produto P
INNER JOIN Estoque E
	ON P.Id = E.IdProduto

SELECT
	SUM(E.Quantidade * (PrecoVenda - Preco)) as LucroEstimado
FROM
	Produto P
INNER JOIN Estoque E
	ON P.Id = E.IdProduto

SELECT
	100*((PrecoVenda - Preco)/Preco) as LucroUnitarioPercentual
FROM
	Produto P

SELECT
	AVG(100*((PrecoVenda - Preco)/Preco)) as MediaLucroUnitarioPercentual
FROM
	Produto P

SELECT
	P.Id,
	min(P.Descricao) as Descricao,
	min(P.Nome) as Nome,
	min(E.Quantidade) as MenorQuantidade,
	SUM(E.Quantidade) as QuantidadeTotal
FROM Produto P LEFT JOIN Estoque E ON P.Id = E.IdProduto
GROUP BY P.Id
HAVING min(E.Quantidade) > 3


SELECT
	* 
FROM Estoque E RIGHT JOIN Produto P ON P.Id = E.IdProduto

SELECT
	*
FROM
	Usuario U
FULL JOIN Estoque E
	ON E.Id IS NOT NULL

SELECT 
	Count(*)
FROM Usuario U
INNER JOIN Perfil P
	ON P.Id = U.IdPerfil
CROSS JOIN Estoque
Where P.Nome = 'ADMIN'
