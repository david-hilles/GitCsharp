CREATE TABLE [dbo].[Notas] (
    [Id]    INT IDENTITY (1, 1) NOT NULL,
    [Nota1] INT NOT NULL,
    [Aluno] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Notas_Aluno] FOREIGN KEY ([Aluno]) REFERENCES [dbo].[Aluno] ([Id])
);

