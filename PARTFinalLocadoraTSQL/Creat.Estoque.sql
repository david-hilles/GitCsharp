CREATE TABLE [dbo].[Estoque] (
    [Id]         INT IDENTITY (1, 1) NOT NULL,
    [IdVeiculo]  INT NOT NULL,
    [IdLocacao]  INT NOT NULL,
    [Disponivel] BIT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Estoque_Locacao] FOREIGN KEY ([IdVeiculo]) REFERENCES [dbo].[Locacao] ([Id])
);

