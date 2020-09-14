

IF (OBJECT_ID('sp_ToTalPedido', 'P') IS NOT NULL)
  DROP PROCEDURE sp_ToTalPedido
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE sp_ToTalPedido
( 
	@CodPedido int
)
AS
BEGIN

	SET NOCOUNT ON;

	DECLARE  @Resultado DECIMAL

	Set @Resultado = (SELECT SUM(B.Preco * A.Quantidade) 
	FROM  dbo.tbPedido A INNER JOIN
    dbo.tbProduto B ON A.CodProduto =B.CodProduto
	where A.CodPedido = @CodPedido)


	Select ISNULL(@Resultado,0);

END
GO

