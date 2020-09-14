
USE [dbTeste]
GO

if exists (select * from INFORMATION_SCHEMA.TABLES where TABLE_NAME = 'tbUF' AND TABLE_SCHEMA = 'dbo')
    drop table dbo.tbUF;

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbUF](
	[CodUF] [int] NOT NULL,
	[UF] [varchar](60) NOT NULL,
	[Sigla] [char](2) NOT NULL
) ON [PRIMARY]
GO