
IF (OBJECT_ID('sp_InsertProduto', 'P') IS NOT NULL)
  DROP PROCEDURE sp_InsertProduto
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE sp_InsertProduto
( 
	@NomeProduto varchar(200),
	@Preco decimal(10,2)
)
AS
BEGIN

	SET NOCOUNT ON;

    INSERT INTO tbProduto
           (NomeProduto
           ,Preco)
     VALUES
           (@NomeProduto
           ,@Preco)

END
GO

