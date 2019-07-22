CREATE TABLE [dbo].[Clientes] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [Nome]      VARCHAR (100) NOT NULL,
    [Obs]       VARCHAR (500) NOT NULL,
    [IdLocacao] INT           NOT NULL,
    [idusuario] INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Clientes_Locacao] FOREIGN KEY ([IdLocacao]) REFERENCES [dbo].[Locacao] ([Id]),
    CONSTRAINT [FK_Clientes_Usuarios] FOREIGN KEY ([idusuario]) REFERENCES [dbo].[Usuarios] ([Id])
);

