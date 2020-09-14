USE [MVC]
GO

IF OBJECT_ID('tbFornecedor', 'U') IS NOT NULL 
  DROP TABLE tbFornecedor;
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE tbFornecedor(
	CodFornecedor int IDENTITY(1,1) NOT NULL,
	NomeFornecedor varchar(200) NOT NULL,
	Statuc char(1) NOT NULL,
 CONSTRAINT [PK_tbFornecedor] PRIMARY KEY CLUSTERED 
(
	CodFornecedor ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'A - Ativo, I - Inativo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tbFornecedor', @level2type=N'COLUMN',@level2name=N'Statuc'
GO


