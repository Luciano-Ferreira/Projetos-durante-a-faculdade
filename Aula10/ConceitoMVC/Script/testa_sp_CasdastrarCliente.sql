USE [MVC]
GO

DECLARE	@return_value int,
		@MsgErro varchar(200)

EXEC	@return_value = [dbo].[sp_CadastrarCliente]
		@NomeCliente = N'Nome 4',
		@Idade = 1,
		@sexo = 'M',
		@MsgErro = @MsgErro OUTPUT

SELECT	@MsgErro as N'@MsgErro'

SELECT	'Return Value' = @return_value

GO
