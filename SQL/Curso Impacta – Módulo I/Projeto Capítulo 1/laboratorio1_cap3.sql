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
	