USE [MVC]
GO


IF OBJECT_ID('tbCliente', 'U') IS NOT NULL 
  DROP TABLE tbCliente;
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE tbCliente(
	CodCliente int IDENTITY(1,1) NOT NULL,
	NomeCliente varchar(200) NOT NULL UNIQUE,
	Idade int NOT NULL,
	sexo char(1) NOT NULL,
 CONSTRAINT PK_tbCliente PRIMARY KEY CLUSTERED 
(
	CodCliente ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


