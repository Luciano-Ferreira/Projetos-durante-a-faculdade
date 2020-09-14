IF (OBJECT_ID('sp_AtualizarProduto', 'P') IS NOT NULL)
  DROP PROCEDURE sp_AtualizarProduto
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE sp_AtualizarProduto
( 
	@CodProduto int,
	@NomeProduto varchar(200),
	@Preco decimal(10,2)
)
AS
BEGIN

	SET NOCOUNT ON;

	UPDATE tbProduto
	   SET NomeProduto = @NomeProduto
		  ,Preco = @Preco
	 WHERE CodProduto = @CodProduto

END
GO
