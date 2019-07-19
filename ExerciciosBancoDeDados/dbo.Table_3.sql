CREATE TABLE [dbo].[Frequencia]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY (1, 1), 
    [Data] DATETIME NOT NULL, 
    [Ativo] BIT NOT NULL,
	[Aluno] INT NOT NULL

	CONSTRAINT [FK_Notas_Aluno] 
	FOREIGN KEY ([Aluno])
	REFERENCES [Aluno]([Id])

)
