CREATE TABLE [dbo].[Diario] (
    [Id]     INT           IDENTITY (1, 1) NOT NULL,
    [Data]   DATETIME      DEFAULT (getdate()) NOT NULL,
    [Turma]  INT           NOT NULL,
    [Obs]    VARCHAR (500) NULL,
    [Ativo]  BIT           NOT NULL,
    [UsuInc] INT           NOT NULL,
    [UsuAlt] INT           NOT NULL,
    [DatInc] DATETIME      NOT NULL,
    [DatAlt] DATETIME      NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Diario_Usuario_Alt] FOREIGN KEY ([UsuAlt]) REFERENCES [dbo].[Usuarios] ([Id]),
    CONSTRAINT [FK_Diario_Usuario_Inc] FOREIGN KEY ([UsuInc]) REFERENCES [dbo].[Usuarios] ([Id])
);

