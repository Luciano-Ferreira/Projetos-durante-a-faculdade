USE [dbTeste]
GO

if exists (select * from INFORMATION_SCHEMA.TABLES where TABLE_NAME = 'tbIBGEMunicipios' AND TABLE_SCHEMA = 'dbo')
    drop table dbo.tbUF;

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbIBGEMunicipios](
	[UF] [varchar](60) NOT NULL,
	[CodUF] [int] NOT NULL,
	[Codmundv] [int] NOT NULL,
	[Codmun] [int] NOT NULL,
	[NomeMunic] [varchar](80) NOT NULL
) ON [PRIMARY]
GO

