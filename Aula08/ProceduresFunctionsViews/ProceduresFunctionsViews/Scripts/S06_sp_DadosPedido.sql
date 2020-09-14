
IF (OBJECT_ID('sp_DadosPedido', 'P') IS NOT NULL)
  DROP PROCEDURE sp_DadosPedido
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE sp_DadosPedido
( 
	@CodPedido int
)
AS
BEGIN

	SET NOCOUNT ON;
	-- Este Select Usa a Própria View como se fosse uma "tabela"	
	-- Note-se o uso da clausula where 
	-- OBSERVE QUE NAO EXISTE A PALAVRA RETURN NA PROC, MAS EXISTE NA FUNCTION
	SELECT CodPedido, CodProduto, NomeProduto, Preco, Quantidade FROM RelatorioPedidos
					where CodPedido = @CodPedido
END
GO




