USE [MVC]
GO
/****** Object:  Table [dbo].[tbFornecedor]    Script Date: 11/09/2016 15:07:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbFornecedor](
	[CodFornecedor] [int] IDENTITY(1,1) NOT NULL,
	[NomeFornecedor] [varchar](200) NOT NULL,
	[Statuc] [char](1) NOT NULL,
 CONSTRAINT [PK_tbFornecedor] PRIMARY KEY CLUSTERED 
(
	[CodFornecedor] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'A - Ativo, I - Inativo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tbFornecedor', @level2type=N'COLUMN',@level2name=N'Statuc'
GO
/****** Object:  Table [dbo].[tbCliente]    Script Date: 11/09/2016 15:07:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbCliente](
	[CodCliente] [int] IDENTITY(1,1) NOT NULL,
	[NomeCliente] [varchar](200) NOT NULL,
	[Idade] [int] NOT NULL,
	[sexo] [char](1) NOT NULL,
 CONSTRAINT [PK_tbCliente] PRIMARY KEY CLUSTERED 
(
	[CodCliente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[NomeCliente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[sp_ConsultaTodosClientes]    Script Date: 11/09/2016 15:07:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ConsultaTodosClientes]
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
/****** Object:  StoredProcedure [dbo].[sp_CadastrarCliente]    Script Date: 11/09/2016 15:07:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_CadastrarCliente] 
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
