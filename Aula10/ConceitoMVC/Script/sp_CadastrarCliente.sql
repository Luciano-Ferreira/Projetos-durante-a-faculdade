
USE MVC
GO

IF OBJECT_ID('sp_CadastrarCliente', 'P') IS NOT NULL
    DROP PROCEDURE sp_CadastrarCliente;
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE sp_CadastrarCliente 
	@NomeCliente varchar(200) ,
	@Idade int ,
	@sexo char,
	@MsgErro varchar(200) output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DECLARE @Qtd INT;

	BEGIN TRY

		Set @Qtd = (select count(*) from tbCliente where NomeCliente = @NomeCliente);

		IF  @Qtd <= 0
		BEGIN
			INSERT INTO tbCliente(NomeCliente,Idade,sexo)
				 VALUES(@NomeCliente,@Idade,@sexo);

			Set @MsgErro = 'Cadatro Efetuado com Sucesso';
		END
		ELSE
		BEGIN
			Set @MsgErro = 'Cliente ja casatrado';
		END

	END TRY
	BEGIN CATCH
		Set @MsgErro = 'Falha ao cadastrar';
	END CATCH

END
GO
