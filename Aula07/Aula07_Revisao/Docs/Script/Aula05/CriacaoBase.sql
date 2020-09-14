
use dbPedidos
go

IF EXISTS (SELECT name FROM sysindexes WHERE name = '[XPKPedidos]')
DROP INDEX [XPKPedidos] ON [Pedidos]
go

IF EXISTS (SELECT name FROM sysindexes WHERE name = '[XIF1Pedidos]')
DROP INDEX [XIF1Pedidos] ON [Pedidos]
go
IF EXISTS (SELECT name FROM sysindexes WHERE name = '[XIF2Pedidos]')
DROP INDEX [XIF2Pedidos] ON [Pedidos]
go
IF EXISTS (SELECT name FROM sysindexes WHERE name = '[XPKEstoque]')
DROP INDEX [XPKEstoque] ON [Estoque]
go
IF EXISTS (SELECT name FROM sysindexes WHERE name = '[XIF1Estoque]')
DROP INDEX [XIF1Estoque] ON [Estoque]
go
IF EXISTS (SELECT name FROM sysindexes WHERE name = '[XPKCliente]')
DROP INDEX [XPKCliente] ON [Cliente]
go
IF EXISTS (SELECT name FROM sysindexes WHERE name = '[XPKProdutoFornecedor]')
DROP INDEX [XPKProdutoFornecedor] ON [ProdutoFornecedor]
go
IF EXISTS (SELECT name FROM sysindexes WHERE name = '[XIF1ProdutoFornecedor]')
DROP INDEX [XIF1ProdutoFornecedor] ON [ProdutoFornecedor]
go
IF EXISTS (SELECT name FROM sysindexes WHERE name = '[XIF2ProdutoFornecedor]')
DROP INDEX [XIF2ProdutoFornecedor] ON [ProdutoFornecedor]
go
IF EXISTS (SELECT name FROM sysindexes WHERE name = '[XIF3ProdutoFornecedor]')
DROP INDEX [XIF3ProdutoFornecedor] ON [ProdutoFornecedor]
go
IF EXISTS (SELECT name FROM sysindexes WHERE name = '[XPKCategoriaProdutos]')
DROP INDEX [XPKCategoriaProdutos] ON [CategoriaProdutos]
go
IF EXISTS (SELECT name FROM sysindexes WHERE name = '[XPKFornecedor]')
DROP INDEX [XPKFornecedor] ON [Fornecedor]
go
IF EXISTS (SELECT name FROM sysindexes WHERE name = '[XPKProduto]')
DROP INDEX [XPKProduto] ON [Produto]
go
IF OBJECT_ID('dbo.Pedidos', 'U') IS NOT NULL 
DROP TABLE [Pedidos]
go
IF OBJECT_ID('dbo.Estoque', 'U') IS NOT NULL 
DROP TABLE [Estoque]
go
IF OBJECT_ID('dbo.Cliente', 'U') IS NOT NULL 
DROP TABLE [Cliente]
go
IF OBJECT_ID('dbo.ProdutoFornecedor', 'U') IS NOT NULL 
DROP TABLE [ProdutoFornecedor]
go
IF OBJECT_ID('dbo.CategoriaProdutos', 'U') IS NOT NULL 
DROP TABLE [CategoriaProdutos]
go
IF OBJECT_ID('dbo.Fornecedor', 'U') IS NOT NULL 
DROP TABLE [Fornecedor]
go
IF OBJECT_ID('dbo.Produto', 'U') IS NOT NULL 
DROP TABLE [Produto]
go



CREATE TABLE [CategoriaProdutos]
( 
	[CodigoCategoria]    integer  NOT NULL ,
	[NomeCategoria]      varchar(40)  NOT NULL 
)
go

ALTER TABLE [CategoriaProdutos]
	ADD CONSTRAINT [XPKCategoriaProdutos] PRIMARY KEY  CLUSTERED ([CodigoCategoria] ASC)
go

CREATE TABLE [Cliente]
( 
	[CodigoCliente]      integer  NOT NULL ,
	[NomeCliente]        varchar(200)  NOT NULL 
)
go

ALTER TABLE [Cliente]
	ADD CONSTRAINT [XPKCliente] PRIMARY KEY  CLUSTERED ([CodigoCliente] ASC)
go

CREATE TABLE [Estoque]
( 
	[Quantidade]         integer  NOT NULL ,
	[CodigoProduto]      integer  NOT NULL ,
	[CodigoLote]         integer  NOT NULL  IDENTITY ,
	[QuantidadeRecebida] integer  NOT NULL ,
	[DataRecebimento]    datetime  NOT NULL ,
	[CodigoLoteFornecedor] varchar(100)  NULL 
)
go

ALTER TABLE [Estoque]
	ADD CONSTRAINT [XPKEstoque] PRIMARY KEY  CLUSTERED ([CodigoLote] ASC,[CodigoProduto] ASC)
go

CREATE TABLE [Fornecedor]
( 
	[CodigoFornecedor]   integer  NOT NULL ,
	[Nome]               varchar(200)  NOT NULL ,
	[Descricao]          varchar(300)  NULL 
)
go

ALTER TABLE [Fornecedor]
	ADD CONSTRAINT [XPKFornecedor] PRIMARY KEY  CLUSTERED ([CodigoFornecedor] ASC)
go

CREATE TABLE [Pedidos]
( 
	[CodigoCliente]      integer  NOT NULL ,
	[Quantidade]         integer  NOT NULL ,
	[DataPedido]         datetime  NULL ,
	[CodigoProduto]      integer  NOT NULL ,
	[CodigoLote]         integer  NOT NULL ,
	[TotalLote]          integer  NOT NULL ,
	[StatusPedido]       char(1)  NOT NULL ,
	[DataCancelamento]   datetime  NULL 
)
go

ALTER TABLE [Pedidos]
	ADD CONSTRAINT [XPKPedidos] PRIMARY KEY  CLUSTERED ([CodigoCliente] ASC,[CodigoProduto] ASC,[CodigoLote] ASC)
go

CREATE TABLE [Produto]
( 
	[CodigoProduto]      integer  NOT NULL ,
	[Nome]               varchar(50)  NOT NULL ,
	[Descricao]          varchar(300)  NULL 
)
go

ALTER TABLE [Produto]
	ADD CONSTRAINT [XPKProduto] PRIMARY KEY  CLUSTERED ([CodigoProduto] ASC)
go

CREATE TABLE [ProdutoFornecedor]
( 
	[CodigoProduto]      integer  NOT NULL ,
	[CodigoFornecedor]   integer  NOT NULL ,
	[CodigoCategoria]    integer  NULL ,
	[NomeProdutoFornecedor] varchar(200)  NULL ,
	[NomeCategoriaProdutoFernecedor] char(18)  NULL 
)
go

ALTER TABLE [ProdutoFornecedor]
	ADD CONSTRAINT [XPKProdutoFornecedor] PRIMARY KEY  CLUSTERED ([CodigoProduto] ASC,[CodigoFornecedor] ASC)
go


ALTER TABLE [Estoque]
	ADD CONSTRAINT [R_8] FOREIGN KEY ([CodigoProduto]) REFERENCES [Produto]([CodigoProduto])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE [Pedidos]
	ADD CONSTRAINT [R_5] FOREIGN KEY ([CodigoCliente]) REFERENCES [Cliente]([CodigoCliente])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [Pedidos]
	ADD CONSTRAINT [R_9] FOREIGN KEY ([CodigoLote],[CodigoProduto]) REFERENCES [Estoque]([CodigoLote],[CodigoProduto])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE [ProdutoFornecedor]
	ADD CONSTRAINT [R_1] FOREIGN KEY ([CodigoProduto]) REFERENCES [Produto]([CodigoProduto])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [ProdutoFornecedor]
	ADD CONSTRAINT [R_2] FOREIGN KEY ([CodigoFornecedor]) REFERENCES [Fornecedor]([CodigoFornecedor])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [ProdutoFornecedor]
	ADD CONSTRAINT [R_3] FOREIGN KEY ([CodigoCategoria]) REFERENCES [CategoriaProdutos]([CodigoCategoria])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


CREATE TRIGGER tD_CategoriaProdutos ON CategoriaProdutos FOR DELETE AS
/* erwin Builtin Trigger */
/* DELETE trigger on CategoriaProdutos */
BEGIN
  DECLARE  @errno   int,
           @severity int,
           @state    int,
           @errmsg  varchar(255)
    /* erwin Builtin Trigger */
    /* CategoriaProdutos  ProdutoFornecedor on parent delete no action */
    /* ERWIN_RELATION:CHECKSUM="00013b32", PARENT_OWNER="", PARENT_TABLE="CategoriaProdutos"
    CHILD_OWNER="", CHILD_TABLE="ProdutoFornecedor"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_3", FK_COLUMNS="CodigoCategoria" */
    IF EXISTS (
      SELECT * FROM deleted,ProdutoFornecedor
      WHERE
        /*  %JoinFKPK(ProdutoFornecedor,deleted," = "," AND") */
        ProdutoFornecedor.CodigoCategoria = deleted.CodigoCategoria
    )
    BEGIN
      SELECT @errno  = 30001,
             @errmsg = 'Cannot delete CategoriaProdutos because ProdutoFornecedor exists.'
      GOTO error
    END


    /* erwin Builtin Trigger */
    RETURN
error:
   RAISERROR (@errmsg, -- Message text.
              @severity, -- Severity (0~25).
              @state) -- State (0~255).
    rollback transaction
END

go


CREATE TRIGGER tU_CategoriaProdutos ON CategoriaProdutos FOR UPDATE AS
/* erwin Builtin Trigger */
/* UPDATE trigger on CategoriaProdutos */
BEGIN
  DECLARE  @numrows int,
           @nullcnt int,
           @validcnt int,
           @insCodigoCategoria integer,
           @errno   int,
           @severity int,
           @state    int,
           @errmsg  varchar(255)

  SELECT @numrows = @@rowcount
  /* erwin Builtin Trigger */
  /* CategoriaProdutos  ProdutoFornecedor on parent update no action */
  /* ERWIN_RELATION:CHECKSUM="00015673", PARENT_OWNER="", PARENT_TABLE="CategoriaProdutos"
    CHILD_OWNER="", CHILD_TABLE="ProdutoFornecedor"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_3", FK_COLUMNS="CodigoCategoria" */
  IF
    /* %ParentPK(" OR",UPDATE) */
    UPDATE(CodigoCategoria)
  BEGIN
    IF EXISTS (
      SELECT * FROM deleted,ProdutoFornecedor
      WHERE
        /*  %JoinFKPK(ProdutoFornecedor,deleted," = "," AND") */
        ProdutoFornecedor.CodigoCategoria = deleted.CodigoCategoria
    )
    BEGIN
      SELECT @errno  = 30005,
             @errmsg = 'Cannot update CategoriaProdutos because ProdutoFornecedor exists.'
      GOTO error
    END
  END


  /* erwin Builtin Trigger */
  RETURN
error:
   RAISERROR (@errmsg, -- Message text.
              @severity, -- Severity (0~25).
              @state) -- State (0~255).
    rollback transaction
END

go




CREATE TRIGGER tD_Cliente ON Cliente FOR DELETE AS
/* erwin Builtin Trigger */
/* DELETE trigger on Cliente */
BEGIN
  DECLARE  @errno   int,
           @severity int,
           @state    int,
           @errmsg  varchar(255)
    /* erwin Builtin Trigger */
    /* Cliente  Pedidos on parent delete no action */
    /* ERWIN_RELATION:CHECKSUM="00010f7b", PARENT_OWNER="", PARENT_TABLE="Cliente"
    CHILD_OWNER="", CHILD_TABLE="Pedidos"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_5", FK_COLUMNS="CodigoCliente" */
    IF EXISTS (
      SELECT * FROM deleted,Pedidos
      WHERE
        /*  %JoinFKPK(Pedidos,deleted," = "," AND") */
        Pedidos.CodigoCliente = deleted.CodigoCliente
    )
    BEGIN
      SELECT @errno  = 30001,
             @errmsg = 'Cannot delete Cliente because Pedidos exists.'
      GOTO error
    END


    /* erwin Builtin Trigger */
    RETURN
error:
   RAISERROR (@errmsg, -- Message text.
              @severity, -- Severity (0~25).
              @state) -- State (0~255).
    rollback transaction
END

go


CREATE TRIGGER tU_Cliente ON Cliente FOR UPDATE AS
/* erwin Builtin Trigger */
/* UPDATE trigger on Cliente */
BEGIN
  DECLARE  @numrows int,
           @nullcnt int,
           @validcnt int,
           @insCodigoCliente integer,
           @errno   int,
           @severity int,
           @state    int,
           @errmsg  varchar(255)

  SELECT @numrows = @@rowcount
  /* erwin Builtin Trigger */
  /* Cliente  Pedidos on parent update no action */
  /* ERWIN_RELATION:CHECKSUM="00012d0e", PARENT_OWNER="", PARENT_TABLE="Cliente"
    CHILD_OWNER="", CHILD_TABLE="Pedidos"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_5", FK_COLUMNS="CodigoCliente" */
  IF
    /* %ParentPK(" OR",UPDATE) */
    UPDATE(CodigoCliente)
  BEGIN
    IF EXISTS (
      SELECT * FROM deleted,Pedidos
      WHERE
        /*  %JoinFKPK(Pedidos,deleted," = "," AND") */
        Pedidos.CodigoCliente = deleted.CodigoCliente
    )
    BEGIN
      SELECT @errno  = 30005,
             @errmsg = 'Cannot update Cliente because Pedidos exists.'
      GOTO error
    END
  END


  /* erwin Builtin Trigger */
  RETURN
error:
   RAISERROR (@errmsg, -- Message text.
              @severity, -- Severity (0~25).
              @state) -- State (0~255).
    rollback transaction
END

go




CREATE TRIGGER tD_Estoque ON Estoque FOR DELETE AS
/* erwin Builtin Trigger */
/* DELETE trigger on Estoque */
BEGIN
  DECLARE  @errno   int,
           @severity int,
           @state    int,
           @errmsg  varchar(255)
    /* erwin Builtin Trigger */
    /* Estoque  Pedidos on parent delete no action */
    /* ERWIN_RELATION:CHECKSUM="000246ff", PARENT_OWNER="", PARENT_TABLE="Estoque"
    CHILD_OWNER="", CHILD_TABLE="Pedidos"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_9", FK_COLUMNS="CodigoLote""CodigoProduto" */
    IF EXISTS (
      SELECT * FROM deleted,Pedidos
      WHERE
        /*  %JoinFKPK(Pedidos,deleted," = "," AND") */
        Pedidos.CodigoProduto = deleted.CodigoProduto AND
        Pedidos.CodigoLote = deleted.CodigoLote
    )
    BEGIN
      SELECT @errno  = 30001,
             @errmsg = 'Cannot delete Estoque because Pedidos exists.'
      GOTO error
    END

    /* erwin Builtin Trigger */
    /* Produto  Estoque on child delete no action */
    /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Produto"
    CHILD_OWNER="", CHILD_TABLE="Estoque"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_8", FK_COLUMNS="CodigoProduto" */
    IF EXISTS (SELECT * FROM deleted,Produto
      WHERE
        /* %JoinFKPK(deleted,Produto," = "," AND") */
        deleted.CodigoProduto = Produto.CodigoProduto AND
        NOT EXISTS (
          SELECT * FROM Estoque
          WHERE
            /* %JoinFKPK(Estoque,Produto," = "," AND") */
            Estoque.CodigoProduto = Produto.CodigoProduto
        )
    )
    BEGIN
      SELECT @errno  = 30010,
             @errmsg = 'Cannot delete last Estoque because Produto exists.'
      GOTO error
    END


    /* erwin Builtin Trigger */
    RETURN
error:
   RAISERROR (@errmsg, -- Message text.
              @severity, -- Severity (0~25).
              @state) -- State (0~255).
    rollback transaction
END

go


CREATE TRIGGER tU_Estoque ON Estoque FOR UPDATE AS
/* erwin Builtin Trigger */
/* UPDATE trigger on Estoque */
BEGIN
  DECLARE  @numrows int,
           @nullcnt int,
           @validcnt int,
           @insCodigoProduto integer, 
           @insCodigoLote integer,
           @errno   int,
           @severity int,
           @state    int,
           @errmsg  varchar(255)

  SELECT @numrows = @@rowcount
  /* erwin Builtin Trigger */
  /* Estoque  Pedidos on parent update no action */
  /* ERWIN_RELATION:CHECKSUM="00029448", PARENT_OWNER="", PARENT_TABLE="Estoque"
    CHILD_OWNER="", CHILD_TABLE="Pedidos"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_9", FK_COLUMNS="CodigoLote""CodigoProduto" */
  IF
    /* %ParentPK(" OR",UPDATE) */
    UPDATE(CodigoProduto) OR
    UPDATE(CodigoLote)
  BEGIN
    IF EXISTS (
      SELECT * FROM deleted,Pedidos
      WHERE
        /*  %JoinFKPK(Pedidos,deleted," = "," AND") */
        Pedidos.CodigoProduto = deleted.CodigoProduto AND
        Pedidos.CodigoLote = deleted.CodigoLote
    )
    BEGIN
      SELECT @errno  = 30005,
             @errmsg = 'Cannot update Estoque because Pedidos exists.'
      GOTO error
    END
  END

  /* erwin Builtin Trigger */
  /* Produto  Estoque on child update no action */
  /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Produto"
    CHILD_OWNER="", CHILD_TABLE="Estoque"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_8", FK_COLUMNS="CodigoProduto" */
  IF
    /* %ChildFK(" OR",UPDATE) */
    UPDATE(CodigoProduto)
  BEGIN
    SELECT @nullcnt = 0
    SELECT @validcnt = count(*)
      FROM inserted,Produto
        WHERE
          /* %JoinFKPK(inserted,Produto) */
          inserted.CodigoProduto = Produto.CodigoProduto
    /* %NotnullFK(inserted," IS NULL","select @nullcnt = count(*) from inserted where"," AND") */
    
    IF @validcnt + @nullcnt != @numrows
    BEGIN
      SELECT @errno  = 30007,
             @errmsg = 'Cannot update Estoque because Produto does not exist.'
      GOTO error
    END
  END


  /* erwin Builtin Trigger */
  RETURN
error:
   RAISERROR (@errmsg, -- Message text.
              @severity, -- Severity (0~25).
              @state) -- State (0~255).
    rollback transaction
END

go




CREATE TRIGGER tD_Fornecedor ON Fornecedor FOR DELETE AS
/* erwin Builtin Trigger */
/* DELETE trigger on Fornecedor */
BEGIN
  DECLARE  @errno   int,
           @severity int,
           @state    int,
           @errmsg  varchar(255)
    /* erwin Builtin Trigger */
    /* Fornecedor  ProdutoFornecedor on parent delete no action */
    /* ERWIN_RELATION:CHECKSUM="00012f25", PARENT_OWNER="", PARENT_TABLE="Fornecedor"
    CHILD_OWNER="", CHILD_TABLE="ProdutoFornecedor"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_2", FK_COLUMNS="CodigoFornecedor" */
    IF EXISTS (
      SELECT * FROM deleted,ProdutoFornecedor
      WHERE
        /*  %JoinFKPK(ProdutoFornecedor,deleted," = "," AND") */
        ProdutoFornecedor.CodigoFornecedor = deleted.CodigoFornecedor
    )
    BEGIN
      SELECT @errno  = 30001,
             @errmsg = 'Cannot delete Fornecedor because ProdutoFornecedor exists.'
      GOTO error
    END


    /* erwin Builtin Trigger */
    RETURN
error:
   RAISERROR (@errmsg, -- Message text.
              @severity, -- Severity (0~25).
              @state) -- State (0~255).
    rollback transaction
END

go


CREATE TRIGGER tU_Fornecedor ON Fornecedor FOR UPDATE AS
/* erwin Builtin Trigger */
/* UPDATE trigger on Fornecedor */
BEGIN
  DECLARE  @numrows int,
           @nullcnt int,
           @validcnt int,
           @insCodigoFornecedor integer,
           @errno   int,
           @severity int,
           @state    int,
           @errmsg  varchar(255)

  SELECT @numrows = @@rowcount
  /* erwin Builtin Trigger */
  /* Fornecedor  ProdutoFornecedor on parent update no action */
  /* ERWIN_RELATION:CHECKSUM="000151b3", PARENT_OWNER="", PARENT_TABLE="Fornecedor"
    CHILD_OWNER="", CHILD_TABLE="ProdutoFornecedor"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_2", FK_COLUMNS="CodigoFornecedor" */
  IF
    /* %ParentPK(" OR",UPDATE) */
    UPDATE(CodigoFornecedor)
  BEGIN
    IF EXISTS (
      SELECT * FROM deleted,ProdutoFornecedor
      WHERE
        /*  %JoinFKPK(ProdutoFornecedor,deleted," = "," AND") */
        ProdutoFornecedor.CodigoFornecedor = deleted.CodigoFornecedor
    )
    BEGIN
      SELECT @errno  = 30005,
             @errmsg = 'Cannot update Fornecedor because ProdutoFornecedor exists.'
      GOTO error
    END
  END


  /* erwin Builtin Trigger */
  RETURN
error:
   RAISERROR (@errmsg, -- Message text.
              @severity, -- Severity (0~25).
              @state) -- State (0~255).
    rollback transaction
END

go




CREATE TRIGGER tD_Pedidos ON Pedidos FOR DELETE AS
/* erwin Builtin Trigger */
/* DELETE trigger on Pedidos */
BEGIN
  DECLARE  @errno   int,
           @severity int,
           @state    int,
           @errmsg  varchar(255)
    /* erwin Builtin Trigger */
    /* Estoque  Pedidos on child delete no action */
    /* ERWIN_RELATION:CHECKSUM="0002944d", PARENT_OWNER="", PARENT_TABLE="Estoque"
    CHILD_OWNER="", CHILD_TABLE="Pedidos"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_9", FK_COLUMNS="CodigoLote""CodigoProduto" */
    IF EXISTS (SELECT * FROM deleted,Estoque
      WHERE
        /* %JoinFKPK(deleted,Estoque," = "," AND") */
        deleted.CodigoProduto = Estoque.CodigoProduto AND
        deleted.CodigoLote = Estoque.CodigoLote AND
        NOT EXISTS (
          SELECT * FROM Pedidos
          WHERE
            /* %JoinFKPK(Pedidos,Estoque," = "," AND") */
            Pedidos.CodigoProduto = Estoque.CodigoProduto AND
            Pedidos.CodigoLote = Estoque.CodigoLote
        )
    )
    BEGIN
      SELECT @errno  = 30010,
             @errmsg = 'Cannot delete last Pedidos because Estoque exists.'
      GOTO error
    END

    /* erwin Builtin Trigger */
    /* Cliente  Pedidos on child delete no action */
    /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Cliente"
    CHILD_OWNER="", CHILD_TABLE="Pedidos"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_5", FK_COLUMNS="CodigoCliente" */
    IF EXISTS (SELECT * FROM deleted,Cliente
      WHERE
        /* %JoinFKPK(deleted,Cliente," = "," AND") */
        deleted.CodigoCliente = Cliente.CodigoCliente AND
        NOT EXISTS (
          SELECT * FROM Pedidos
          WHERE
            /* %JoinFKPK(Pedidos,Cliente," = "," AND") */
            Pedidos.CodigoCliente = Cliente.CodigoCliente
        )
    )
    BEGIN
      SELECT @errno  = 30010,
             @errmsg = 'Cannot delete last Pedidos because Cliente exists.'
      GOTO error
    END


    /* erwin Builtin Trigger */
    RETURN
error:
   RAISERROR (@errmsg, -- Message text.
              @severity, -- Severity (0~25).
              @state) -- State (0~255).
    rollback transaction
END

go


CREATE TRIGGER tU_Pedidos ON Pedidos FOR UPDATE AS
/* erwin Builtin Trigger */
/* UPDATE trigger on Pedidos */
BEGIN
  DECLARE  @numrows int,
           @nullcnt int,
           @validcnt int,
           @insCodigoCliente integer, 
           @insCodigoProduto integer, 
           @insCodigoLote integer,
           @errno   int,
           @severity int,
           @state    int,
           @errmsg  varchar(255)

  SELECT @numrows = @@rowcount
  /* erwin Builtin Trigger */
  /* Estoque  Pedidos on child update no action */
  /* ERWIN_RELATION:CHECKSUM="0002dc07", PARENT_OWNER="", PARENT_TABLE="Estoque"
    CHILD_OWNER="", CHILD_TABLE="Pedidos"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_9", FK_COLUMNS="CodigoLote""CodigoProduto" */
  IF
    /* %ChildFK(" OR",UPDATE) */
    UPDATE(CodigoProduto) OR
    UPDATE(CodigoLote)
  BEGIN
    SELECT @nullcnt = 0
    SELECT @validcnt = count(*)
      FROM inserted,Estoque
        WHERE
          /* %JoinFKPK(inserted,Estoque) */
          inserted.CodigoProduto = Estoque.CodigoProduto and
          inserted.CodigoLote = Estoque.CodigoLote
    /* %NotnullFK(inserted," IS NULL","select @nullcnt = count(*) from inserted where"," AND") */
    
    IF @validcnt + @nullcnt != @numrows
    BEGIN
      SELECT @errno  = 30007,
             @errmsg = 'Cannot update Pedidos because Estoque does not exist.'
      GOTO error
    END
  END

  /* erwin Builtin Trigger */
  /* Cliente  Pedidos on child update no action */
  /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Cliente"
    CHILD_OWNER="", CHILD_TABLE="Pedidos"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_5", FK_COLUMNS="CodigoCliente" */
  IF
    /* %ChildFK(" OR",UPDATE) */
    UPDATE(CodigoCliente)
  BEGIN
    SELECT @nullcnt = 0
    SELECT @validcnt = count(*)
      FROM inserted,Cliente
        WHERE
          /* %JoinFKPK(inserted,Cliente) */
          inserted.CodigoCliente = Cliente.CodigoCliente
    /* %NotnullFK(inserted," IS NULL","select @nullcnt = count(*) from inserted where"," AND") */
    
    IF @validcnt + @nullcnt != @numrows
    BEGIN
      SELECT @errno  = 30007,
             @errmsg = 'Cannot update Pedidos because Cliente does not exist.'
      GOTO error
    END
  END


  /* erwin Builtin Trigger */
  RETURN
error:
   RAISERROR (@errmsg, -- Message text.
              @severity, -- Severity (0~25).
              @state) -- State (0~255).
    rollback transaction
END

go




CREATE TRIGGER tD_Produto ON Produto FOR DELETE AS
/* erwin Builtin Trigger */
/* DELETE trigger on Produto */
BEGIN
  DECLARE  @errno   int,
           @severity int,
           @state    int,
           @errmsg  varchar(255)
    /* erwin Builtin Trigger */
    /* Produto  Estoque on parent delete no action */
    /* ERWIN_RELATION:CHECKSUM="00021bb7", PARENT_OWNER="", PARENT_TABLE="Produto"
    CHILD_OWNER="", CHILD_TABLE="Estoque"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_8", FK_COLUMNS="CodigoProduto" */
    IF EXISTS (
      SELECT * FROM deleted,Estoque
      WHERE
        /*  %JoinFKPK(Estoque,deleted," = "," AND") */
        Estoque.CodigoProduto = deleted.CodigoProduto
    )
    BEGIN
      SELECT @errno  = 30001,
             @errmsg = 'Cannot delete Produto because Estoque exists.'
      GOTO error
    END

    /* erwin Builtin Trigger */
    /* Produto  ProdutoFornecedor on parent delete no action */
    /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Produto"
    CHILD_OWNER="", CHILD_TABLE="ProdutoFornecedor"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_1", FK_COLUMNS="CodigoProduto" */
    IF EXISTS (
      SELECT * FROM deleted,ProdutoFornecedor
      WHERE
        /*  %JoinFKPK(ProdutoFornecedor,deleted," = "," AND") */
        ProdutoFornecedor.CodigoProduto = deleted.CodigoProduto
    )
    BEGIN
      SELECT @errno  = 30001,
             @errmsg = 'Cannot delete Produto because ProdutoFornecedor exists.'
      GOTO error
    END


    /* erwin Builtin Trigger */
    RETURN
error:
   RAISERROR (@errmsg, -- Message text.
              @severity, -- Severity (0~25).
              @state) -- State (0~255).
    rollback transaction
END

go


CREATE TRIGGER tU_Produto ON Produto FOR UPDATE AS
/* erwin Builtin Trigger */
/* UPDATE trigger on Produto */
BEGIN
  DECLARE  @numrows int,
           @nullcnt int,
           @validcnt int,
           @insCodigoProduto integer,
           @errno   int,
           @severity int,
           @state    int,
           @errmsg  varchar(255)

  SELECT @numrows = @@rowcount
  /* erwin Builtin Trigger */
  /* Produto  Estoque on parent update no action */
  /* ERWIN_RELATION:CHECKSUM="00025e5b", PARENT_OWNER="", PARENT_TABLE="Produto"
    CHILD_OWNER="", CHILD_TABLE="Estoque"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_8", FK_COLUMNS="CodigoProduto" */
  IF
    /* %ParentPK(" OR",UPDATE) */
    UPDATE(CodigoProduto)
  BEGIN
    IF EXISTS (
      SELECT * FROM deleted,Estoque
      WHERE
        /*  %JoinFKPK(Estoque,deleted," = "," AND") */
        Estoque.CodigoProduto = deleted.CodigoProduto
    )
    BEGIN
      SELECT @errno  = 30005,
             @errmsg = 'Cannot update Produto because Estoque exists.'
      GOTO error
    END
  END

  /* erwin Builtin Trigger */
  /* Produto  ProdutoFornecedor on parent update no action */
  /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Produto"
    CHILD_OWNER="", CHILD_TABLE="ProdutoFornecedor"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_1", FK_COLUMNS="CodigoProduto" */
  IF
    /* %ParentPK(" OR",UPDATE) */
    UPDATE(CodigoProduto)
  BEGIN
    IF EXISTS (
      SELECT * FROM deleted,ProdutoFornecedor
      WHERE
        /*  %JoinFKPK(ProdutoFornecedor,deleted," = "," AND") */
        ProdutoFornecedor.CodigoProduto = deleted.CodigoProduto
    )
    BEGIN
      SELECT @errno  = 30005,
             @errmsg = 'Cannot update Produto because ProdutoFornecedor exists.'
      GOTO error
    END
  END


  /* erwin Builtin Trigger */
  RETURN
error:
   RAISERROR (@errmsg, -- Message text.
              @severity, -- Severity (0~25).
              @state) -- State (0~255).
    rollback transaction
END

go




CREATE TRIGGER tD_ProdutoFornecedor ON ProdutoFornecedor FOR DELETE AS
/* erwin Builtin Trigger */
/* DELETE trigger on ProdutoFornecedor */
BEGIN
  DECLARE  @errno   int,
           @severity int,
           @state    int,
           @errmsg  varchar(255)
    /* erwin Builtin Trigger */
    /* CategoriaProdutos  ProdutoFornecedor on child delete no action */
    /* ERWIN_RELATION:CHECKSUM="00043ac3", PARENT_OWNER="", PARENT_TABLE="CategoriaProdutos"
    CHILD_OWNER="", CHILD_TABLE="ProdutoFornecedor"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_3", FK_COLUMNS="CodigoCategoria" */
    IF EXISTS (SELECT * FROM deleted,CategoriaProdutos
      WHERE
        /* %JoinFKPK(deleted,CategoriaProdutos," = "," AND") */
        deleted.CodigoCategoria = CategoriaProdutos.CodigoCategoria AND
        NOT EXISTS (
          SELECT * FROM ProdutoFornecedor
          WHERE
            /* %JoinFKPK(ProdutoFornecedor,CategoriaProdutos," = "," AND") */
            ProdutoFornecedor.CodigoCategoria = CategoriaProdutos.CodigoCategoria
        )
    )
    BEGIN
      SELECT @errno  = 30010,
             @errmsg = 'Cannot delete last ProdutoFornecedor because CategoriaProdutos exists.'
      GOTO error
    END

    /* erwin Builtin Trigger */
    /* Fornecedor  ProdutoFornecedor on child delete no action */
    /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Fornecedor"
    CHILD_OWNER="", CHILD_TABLE="ProdutoFornecedor"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_2", FK_COLUMNS="CodigoFornecedor" */
    IF EXISTS (SELECT * FROM deleted,Fornecedor
      WHERE
        /* %JoinFKPK(deleted,Fornecedor," = "," AND") */
        deleted.CodigoFornecedor = Fornecedor.CodigoFornecedor AND
        NOT EXISTS (
          SELECT * FROM ProdutoFornecedor
          WHERE
            /* %JoinFKPK(ProdutoFornecedor,Fornecedor," = "," AND") */
            ProdutoFornecedor.CodigoFornecedor = Fornecedor.CodigoFornecedor
        )
    )
    BEGIN
      SELECT @errno  = 30010,
             @errmsg = 'Cannot delete last ProdutoFornecedor because Fornecedor exists.'
      GOTO error
    END

    /* erwin Builtin Trigger */
    /* Produto  ProdutoFornecedor on child delete no action */
    /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Produto"
    CHILD_OWNER="", CHILD_TABLE="ProdutoFornecedor"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_1", FK_COLUMNS="CodigoProduto" */
    IF EXISTS (SELECT * FROM deleted,Produto
      WHERE
        /* %JoinFKPK(deleted,Produto," = "," AND") */
        deleted.CodigoProduto = Produto.CodigoProduto AND
        NOT EXISTS (
          SELECT * FROM ProdutoFornecedor
          WHERE
            /* %JoinFKPK(ProdutoFornecedor,Produto," = "," AND") */
            ProdutoFornecedor.CodigoProduto = Produto.CodigoProduto
        )
    )
    BEGIN
      SELECT @errno  = 30010,
             @errmsg = 'Cannot delete last ProdutoFornecedor because Produto exists.'
      GOTO error
    END


    /* erwin Builtin Trigger */
    RETURN
error:
   RAISERROR (@errmsg, -- Message text.
              @severity, -- Severity (0~25).
              @state) -- State (0~255).
    rollback transaction
END

go


CREATE TRIGGER tU_ProdutoFornecedor ON ProdutoFornecedor FOR UPDATE AS
/* erwin Builtin Trigger */
/* UPDATE trigger on ProdutoFornecedor */
BEGIN
  DECLARE  @numrows int,
           @nullcnt int,
           @validcnt int,
           @insCodigoProduto integer, 
           @insCodigoFornecedor integer,
           @errno   int,
           @severity int,
           @state    int,
           @errmsg  varchar(255)

  SELECT @numrows = @@rowcount
  /* erwin Builtin Trigger */
  /* CategoriaProdutos  ProdutoFornecedor on child update no action */
  /* ERWIN_RELATION:CHECKSUM="0004704e", PARENT_OWNER="", PARENT_TABLE="CategoriaProdutos"
    CHILD_OWNER="", CHILD_TABLE="ProdutoFornecedor"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_3", FK_COLUMNS="CodigoCategoria" */
  IF
    /* %ChildFK(" OR",UPDATE) */
    UPDATE(CodigoCategoria)
  BEGIN
    SELECT @nullcnt = 0
    SELECT @validcnt = count(*)
      FROM inserted,CategoriaProdutos
        WHERE
          /* %JoinFKPK(inserted,CategoriaProdutos) */
          inserted.CodigoCategoria = CategoriaProdutos.CodigoCategoria
    /* %NotnullFK(inserted," IS NULL","select @nullcnt = count(*) from inserted where"," AND") */
    select @nullcnt = count(*) from inserted where
      inserted.CodigoCategoria IS NULL
    IF @validcnt + @nullcnt != @numrows
    BEGIN
      SELECT @errno  = 30007,
             @errmsg = 'Cannot update ProdutoFornecedor because CategoriaProdutos does not exist.'
      GOTO error
    END
  END

  /* erwin Builtin Trigger */
  /* Fornecedor  ProdutoFornecedor on child update no action */
  /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Fornecedor"
    CHILD_OWNER="", CHILD_TABLE="ProdutoFornecedor"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_2", FK_COLUMNS="CodigoFornecedor" */
  IF
    /* %ChildFK(" OR",UPDATE) */
    UPDATE(CodigoFornecedor)
  BEGIN
    SELECT @nullcnt = 0
    SELECT @validcnt = count(*)
      FROM inserted,Fornecedor
        WHERE
          /* %JoinFKPK(inserted,Fornecedor) */
          inserted.CodigoFornecedor = Fornecedor.CodigoFornecedor
    /* %NotnullFK(inserted," IS NULL","select @nullcnt = count(*) from inserted where"," AND") */
    
    IF @validcnt + @nullcnt != @numrows
    BEGIN
      SELECT @errno  = 30007,
             @errmsg = 'Cannot update ProdutoFornecedor because Fornecedor does not exist.'
      GOTO error
    END
  END

  /* erwin Builtin Trigger */
  /* Produto  ProdutoFornecedor on child update no action */
  /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Produto"
    CHILD_OWNER="", CHILD_TABLE="ProdutoFornecedor"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_1", FK_COLUMNS="CodigoProduto" */
  IF
    /* %ChildFK(" OR",UPDATE) */
    UPDATE(CodigoProduto)
  BEGIN
    SELECT @nullcnt = 0
    SELECT @validcnt = count(*)
      FROM inserted,Produto
        WHERE
          /* %JoinFKPK(inserted,Produto) */
          inserted.CodigoProduto = Produto.CodigoProduto
    /* %NotnullFK(inserted," IS NULL","select @nullcnt = count(*) from inserted where"," AND") */
    
    IF @validcnt + @nullcnt != @numrows
    BEGIN
      SELECT @errno  = 30007,
             @errmsg = 'Cannot update ProdutoFornecedor because Produto does not exist.'
      GOTO error
    END
  END


  /* erwin Builtin Trigger */
  RETURN
error:
   RAISERROR (@errmsg, -- Message text.
              @severity, -- Severity (0~25).
              @state) -- State (0~255).
    rollback transaction
END

go


