

IF object_id('fn_ToTalPedido') IS NOT NULL
BEGIN
    DROP FUNCTION fn_ToTalPedido
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION fn_ToTalPedido 
(
	@CodPedido int
)
RETURNS DECIMAL
AS
BEGIN
	
	DECLARE  @Resultado DECIMAL

	Set @Resultado = (SELECT SUM(B.Preco * A.Quantidade) 
	FROM  dbo.tbPedido A INNER JOIN
    dbo.tbProduto B ON A.CodProduto =B.CodProduto
	where A.CodPedido = @CodPedido)


	RETURN ISNULL(@Resultado,0);

END
GO

