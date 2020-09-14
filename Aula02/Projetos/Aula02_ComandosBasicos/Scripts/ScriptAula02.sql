
/****** SELECIONA A BASE DE DADOS COM A QUAL SE IRA TRAbALHAR  ******/
USE [master]
GO
/****** VERIFICA SE BASE DE DADOS EXISTE E CASO EXISTA APAGA A Database dbAula02  ******/
IF EXISTS (SELECT name FROM master.sys.databases WHERE name = N'dbAula02')
DROP DATABASE dbAula02;
GO
/****** CRIA A BASE DE DASOS dbAula02   ******/
CREATE DATABASE [dbAula02] 
GO

/****** SELECIONA A BASE DE DADOS COM A QUAL SE IRA TRABALHAR  ******/
USE [dbAula02]
GO

/****** CRIANDO TABELAS DO BANCO DE DADOS ******/

/* PARA QUE SERVEM ESTES COMANDOS PESQUISE */
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/****** CRIANDO A TABELA tb01  ******/
CREATE TABLE [dbo].[tb01](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](10) NOT NULL,
 CONSTRAINT [PK_tb01] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/* PARA QUE SERVEM ESTES COMANDOS PESQUISE */
SET IDENTITY_INSERT [dbo].[tb01] ON 

/****** POPULANDO COM DADOS INICIAIS PARA TESTE  ******/
INSERT [dbo].[tb01] ([Id], [Nome]) VALUES (1, N'Nome 1')
INSERT [dbo].[tb01] ([Id], [Nome]) VALUES (2, N'Nome 2')
INSERT [dbo].[tb01] ([Id], [Nome]) VALUES (3, N'Nome 3')
INSERT [dbo].[tb01] ([Id], [Nome]) VALUES (4, N'Nome 4')
INSERT [dbo].[tb01] ([Id], [Nome]) VALUES (10, N'123456')

/* PARA QUE SERVEM ESTES COMANDOS PESQUISE */
SET IDENTITY_INSERT [dbo].[tb01] OFF

GO