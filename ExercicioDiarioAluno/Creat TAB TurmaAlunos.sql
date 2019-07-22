CREATE TABLE [dbo].[TurmaAlunos] (
    [Turma] INT NOT NULL,
    [Aluno] INT NOT NULL,
    CONSTRAINT [FK_TurmaAlunos_Alunos] FOREIGN KEY ([Aluno]) REFERENCES [dbo].[Alunos] ([Id])
);

