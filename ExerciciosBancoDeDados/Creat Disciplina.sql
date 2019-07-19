CREATE TABLE [dbo].[Aluno] (
    [Id]         INT           IDENTITY (1, 1) NOT NULL,
    [Nome]       VARCHAR (100) NOT NULL,
    [Disciplina] INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Aluno_Disciplina] FOREIGN KEY ([Disciplina]) REFERENCES [dbo].[Disciplina] ([Id])
);

