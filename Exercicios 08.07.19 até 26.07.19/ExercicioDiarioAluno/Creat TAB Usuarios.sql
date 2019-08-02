CREATE TABLE [dbo].[Usuarios] (
    [Id]      INT           IDENTITY (1, 1) NOT NULL,
    [Nome]    VARCHAR (100) NOT NULL,
    [ativo]   BIT           NOT NULL,
    [UsuInc]  INT           NOT NULL,
    [UsuAlt]  INT           NOT NULL,
    [DataInc] DATETIME      NOT NULL,
    [DataAlt] DATETIME      NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

