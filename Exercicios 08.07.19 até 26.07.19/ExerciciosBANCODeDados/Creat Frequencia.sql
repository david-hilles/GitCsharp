CREATE TABLE [dbo].[Frequencia] (
    [Id]    INT          IDENTITY (1, 1) NOT NULL,
    [Data]  VARCHAR (50) NOT NULL,
    [Ativo] BIT          NOT NULL,
    [Aluno] INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Frequencia_Aluno] FOREIGN KEY ([Aluno]) REFERENCES [dbo].[Aluno] ([Id])
);

