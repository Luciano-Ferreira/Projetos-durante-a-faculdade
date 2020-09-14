
USE dbTeste
Go

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('sp_ProcedureSimplesExemplo'))
BEGIN
    DROP PROCEDURE sp_ProcedureSimplesExemplo
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE sp_ProcedureSimplesExemplo 
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * from tb01;
END
GO
