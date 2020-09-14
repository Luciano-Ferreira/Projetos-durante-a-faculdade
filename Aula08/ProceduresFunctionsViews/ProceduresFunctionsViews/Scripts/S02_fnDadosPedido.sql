

IF object_id('fn_DadosPedido') IS NOT NULL
BEGIN
    DROP FUNCTION fn_DadosPedido
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION fn_DadosPedido 
(
	@CodPedido int
)
RETURNS TABLE
AS
	-- Este Select Usa a Própria View como se fosse uma "tabela"	
	-- Note-se o uso da clausula where 
	RETURN (SELECT CodPedido, CodProduto, NomeProduto, Preco, Quantidade FROM RelatorioPedidos
					where CodPedido = @CodPedido)

GO

