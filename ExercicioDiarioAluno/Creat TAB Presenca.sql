CREATE TABLE [dbo].[Presenca] (
    [Id]     INT IDENTITY (1, 1) NOT NULL,
    [Diario] INT NOT NULL,
    [Aluno]  INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Presenca_Alunos] FOREIGN KEY ([Aluno]) REFERENCES [dbo].[Alunos] ([Id])
);

