CREATE TABLE [dbo].[Alunos] (
    [Id]      INT           IDENTITY (1, 1) NOT NULL,
    [Aluno]   VARCHAR (100) NOT NULL,
    [Ativo]   BIT           NOT NULL,
    [UsuInc]  INT           NOT NULL,
    [UsuAlt]  INT           NOT NULL,
    [DataInc] DATETIME      NOT NULL,
    [DataAlt] DATETIME      NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Alunos_Usuarios_Inc] FOREIGN KEY ([UsuInc]) REFERENCES [dbo].[Usuarios] ([Id]),
    CONSTRAINT [FK_Alunos_Usuarios_Alt] FOREIGN KEY ([UsuAlt]) REFERENCES [dbo].[Usuarios] ([Id])
);

