USE [master]
GO

CREATE DATABASE [dbProceduresFunctionsViews] ON  PRIMARY 

USE [dbProceduresFunctionsViews]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[fn_ToTalPedido] 
(
	@CodPedido int
)
RETURNS DECIMAL
AS
BEGIN
	
	DECLARE  @Resultado DECIMAL

	Set @Resultado = (SELECT SUM(B.Preco * A.Quantidade) 
	FROM  dbo.tbPedido A INNER JOIN
    dbo.tbProduto B ON A.CodProduto =B.CodProduto
	where A.CodPedido = @CodPedido)


	RETURN ISNULL(@Resultado,0);

END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbPedido](
	[CodPedido] [int] NOT NULL,
	[CodProduto] [int] NOT NULL,
	[Quantidade] [int] NOT NULL,
 CONSTRAINT [PK_tbPedido] PRIMARY KEY CLUSTERED 
(
	[CodPedido] ASC,
	[CodProduto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbProduto]    Script Date: 16/10/2017 09:44:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbProduto](
	[CodProduto] [int] IDENTITY(1,1) NOT NULL,
	[NomeProduto] [varchar](200) NOT NULL,
	[Preco] [decimal](10, 2) NOT NULL,
 CONSTRAINT [PK_tbProduto] PRIMARY KEY CLUSTERED 
(
	[CodProduto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[RelatorioPedidos]    Script Date: 16/10/2017 09:44:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[RelatorioPedidos]
AS
SELECT        dbo.tbPedido.CodPedido, dbo.tbPedido.CodProduto, dbo.tbProduto.NomeProduto, dbo.tbProduto.Preco, dbo.tbPedido.Quantidade
FROM            dbo.tbPedido INNER JOIN
                         dbo.tbProduto ON dbo.tbPedido.CodProduto = dbo.tbProduto.CodProduto
GO
/****** Object:  UserDefinedFunction [dbo].[fn_DadosPedido]    Script Date: 16/10/2017 09:44:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[fn_DadosPedido] 
(
	@CodPedido int
)
RETURNS TABLE
AS


	RETURN (SELECT CodPedido, CodProduto, NomeProduto, Preco, Quantidade FROM RelatorioPedidos
					where CodPedido = @CodPedido)


GO
INSERT [dbo].[tbPedido] ([CodPedido], [CodProduto], [Quantidade]) VALUES (1, 1, 3)
INSERT [dbo].[tbPedido] ([CodPedido], [CodProduto], [Quantidade]) VALUES (1, 2, 4)
INSERT [dbo].[tbPedido] ([CodPedido], [CodProduto], [Quantidade]) VALUES (1, 3, 3)
INSERT [dbo].[tbPedido] ([CodPedido], [CodProduto], [Quantidade]) VALUES (2, 3, 2)
INSERT [dbo].[tbPedido] ([CodPedido], [CodProduto], [Quantidade]) VALUES (3, 2, 2)

SET IDENTITY_INSERT [dbo].[tbProduto] ON 

INSERT [dbo].[tbProduto] ([CodProduto], [NomeProduto], [Preco]) VALUES (1, N'P1', CAST(10.00 AS Decimal(10, 2)))
INSERT [dbo].[tbProduto] ([CodProduto], [NomeProduto], [Preco]) VALUES (2, N'P2', CAST(20.00 AS Decimal(10, 2)))
INSERT [dbo].[tbProduto] ([CodProduto], [NomeProduto], [Preco]) VALUES (3, N'P3', CAST(30.00 AS Decimal(10, 2)))

SET IDENTITY_INSERT [dbo].[tbProduto] OFF

ALTER TABLE [dbo].[tbPedido]  WITH CHECK ADD  CONSTRAINT [FK_tbPedido_tbProduto] FOREIGN KEY([CodProduto])
REFERENCES [dbo].[tbProduto] ([CodProduto])
GO
ALTER TABLE [dbo].[tbPedido] CHECK CONSTRAINT [FK_tbPedido_tbProduto]
GO
/****** Object:  StoredProcedure [dbo].[sp_ApagarProduto]    Script Date: 16/10/2017 09:44:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ApagarProduto]
( 
	@CodProduto int
)
AS
BEGIN

	SET NOCOUNT ON;

	DELETE FROM tbProduto
		  WHERE CodProduto = @CodProduto

END
GO
/****** Object:  StoredProcedure [dbo].[sp_AtualizarProduto]    Script Date: 16/10/2017 09:44:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_AtualizarProduto]
( 
	@CodProduto int,
	@NomeProduto varchar(200),
	@Preco decimal(10,2)
)
AS
BEGIN

	SET NOCOUNT ON;

	UPDATE tbProduto
	   SET NomeProduto = @NomeProduto
		  ,Preco = @Preco
	 WHERE CodProduto = @CodProduto

END
GO
/****** Object:  StoredProcedure [dbo].[sp_DadosPedido]    Script Date: 16/10/2017 09:44:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_DadosPedido]
( 
	@CodPedido int
)
AS
BEGIN

	SET NOCOUNT ON;
	-- Este Select Usa a Própria View como se fosse uma "tabela"	
	-- Note-se o uso da clausula where 
	-- OBSERVE QUE NAO EXISTE A PALAVRA RETURN NA PROC, MAS EXISTE NA FUNCTION
	SELECT CodPedido, CodProduto, NomeProduto, Preco, Quantidade FROM RelatorioPedidos
					where CodPedido = @CodPedido
END
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertProduto]    Script Date: 16/10/2017 09:44:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_InsertProduto]
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
/****** Object:  StoredProcedure [dbo].[sp_ToTalPedido]    Script Date: 16/10/2017 09:44:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ToTalPedido]
( 
	@CodPedido int
)
AS
BEGIN

	SET NOCOUNT ON;

	DECLARE  @Resultado DECIMAL

	Set @Resultado = (SELECT SUM(B.Preco * A.Quantidade) 
	FROM  dbo.tbPedido A INNER JOIN
    dbo.tbProduto B ON A.CodProduto =B.CodProduto
	where A.CodPedido = @CodPedido)


	Select ISNULL(@Resultado,0);

END
GO
USE [master]
GO
ALTER DATABASE [dbProceduresFunctionsViews] SET  READ_WRITE 
GO
