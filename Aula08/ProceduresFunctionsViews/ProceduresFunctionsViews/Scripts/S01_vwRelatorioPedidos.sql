
USE [dbProceduresFunctionsViews]
GO

if object_id('RelatorioPedidos','v') is not null
drop view RelatorioPedidos;
go

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW RelatorioPedidos
AS
SELECT dbo.tbPedido.CodPedido, 
	dbo.tbPedido.CodProduto,
	dbo.tbProduto.NomeProduto,
	dbo.tbProduto.Preco,
	dbo.tbPedido.Quantidade
FROM dbo.tbPedido INNER JOIN
	dbo.tbProduto ON 
	dbo.tbPedido.CodProduto = 
		dbo.tbProduto.CodProduto
GO
