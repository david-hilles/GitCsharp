CREATE TABLE [dbo].[Carros] (
    [Id]          INT          IDENTITY (1, 1) NOT NULL,
    [Placa]       VARCHAR (50) NOT NULL,
    [marca]       VARCHAR (50) NOT NULL,
    [Ano]         INT          NOT NULL,
    [ValorDiaria] INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

