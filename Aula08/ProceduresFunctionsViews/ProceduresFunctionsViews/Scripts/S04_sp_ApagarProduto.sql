IF (OBJECT_ID('sp_ApagarProduto', 'P') IS NOT NULL)
  DROP PROCEDURE sp_ApagarProduto
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE sp_ApagarProduto
( 
	@CodProduto int
)
AS
BEGIN

	SET NOCOUNT ON;

	DELETE FROM tbProduto
		  WHERE CodProduto = @CodProduto

END
GO
