CREATE TABLE [dbo].[Locacao] (
    [Id]            INT      IDENTITY (1, 1) NOT NULL,
    [CodigoLocacao] INT      NOT NULL,
    [CodigoCliente] INT      NOT NULL,
    [DataInicio]    DATETIME NOT NULL,
    [DataFim]       DATETIME NOT NULL,
    [Idcarros]      INT      NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Locacao_Carros] FOREIGN KEY ([Idcarros]) REFERENCES [dbo].[Carros] ([Id])
);

