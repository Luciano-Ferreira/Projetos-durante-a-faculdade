
USE MVC
GO

IF OBJECT_ID('sp_ConsultaTodosClientes', 'P') IS NOT NULL
    DROP PROCEDURE sp_ConsultaTodosClientes;
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE sp_ConsultaTodosClientes
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	-- with (NOLOCK) EVITA QUE SEJAN TRAVADOS OS REGISTROS DAS TABELAS
	-- isso acerela transações porém pode provocar leituras sujas
	-- deve ser usado com moderação e apenas quando se sabe
	-- como a tabela é usada.
	SELECT CodCliente,NomeCliente,Idade,sexo
	  FROM tbCliente with (NOLOCK)

END
GO
