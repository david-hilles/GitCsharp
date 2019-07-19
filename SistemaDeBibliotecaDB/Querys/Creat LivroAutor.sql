CREATE TABLE [dbo].[LivroAutor] (
    [Livro] INT NOT NULL,
    [Autor] INT NOT NULL,
    CONSTRAINT [FK_LivroAutor_Autores] FOREIGN KEY ([Autor]) REFERENCES [dbo].[Livros] ([Id]),
    CONSTRAINT [FK_LivroAutor_Livros] FOREIGN KEY ([Livro]) REFERENCES [dbo].[Livros] ([Id])
);

