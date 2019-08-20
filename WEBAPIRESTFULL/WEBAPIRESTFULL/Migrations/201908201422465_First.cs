namespace WEBAPIRESTFULL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Autores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100, unicode: false),
                        Descricao = c.String(maxLength: 1000, unicode: false),
                        Ativo = c.Boolean(),
                        UsuInc = c.Int(),
                        UsuAlt = c.Int(),
                        DatInc = c.DateTime(),
                        DatAlt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Livros",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Registro = c.Int(nullable: false),
                        Titulo = c.String(nullable: false, maxLength: 1200, unicode: false),
                        Isbn = c.String(nullable: false, maxLength: 15, unicode: false),
                        Genero = c.Int(nullable: false),
                        Editora = c.Int(nullable: false),
                        Sinopse = c.String(),
                        Observacoes = c.String(maxLength: 1000, unicode: false),
                        Ativo = c.Boolean(),
                        UsuInc = c.Int(),
                        UsuAlt = c.Int(),
                        DatInc = c.DateTime(),
                        DatAlt = c.DateTime(),
                        Usuarios_Id = c.Int(),
                        Usuarios_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Editoras", t => t.Editora)
                .ForeignKey("dbo.Generos", t => t.Genero)
                .ForeignKey("dbo.Usuarios", t => t.Usuarios_Id)
                .ForeignKey("dbo.Usuarios", t => t.Usuarios_Id1)
                .Index(t => t.Genero)
                .Index(t => t.Editora)
                .Index(t => t.Usuarios_Id)
                .Index(t => t.Usuarios_Id1);
            
            CreateTable(
                "dbo.Editoras",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 200, unicode: false),
                        Descricao = c.String(maxLength: 1000, unicode: false),
                        Ativo = c.Boolean(),
                        UsuInc = c.Int(),
                        UsuAlt = c.Int(),
                        DatInc = c.DateTime(),
                        DatAlt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Generos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tipo = c.String(nullable: false, maxLength: 200, unicode: false),
                        Descricao = c.String(maxLength: 1000, unicode: false),
                        Ativo = c.Boolean(),
                        UsuInc = c.Int(),
                        UsuAlt = c.Int(),
                        DatInc = c.DateTime(),
                        DatAlt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Locacao",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Livro = c.Int(nullable: false),
                        Usuario = c.Int(nullable: false),
                        Tipo = c.Int(nullable: false),
                        Devolucao = c.DateTime(nullable: false),
                        Ativo = c.Boolean(),
                        UsuInc = c.Int(),
                        UsuAlt = c.Int(),
                        DatInc = c.DateTime(),
                        DatAlt = c.DateTime(),
                        Usuarios_Id = c.Int(),
                        Usuarios_Id1 = c.Int(),
                        Usuarios_Id2 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Livros", t => t.Livro)
                .ForeignKey("dbo.Usuarios", t => t.Usuarios_Id)
                .ForeignKey("dbo.Usuarios", t => t.Usuarios_Id1)
                .ForeignKey("dbo.Usuarios", t => t.Usuarios_Id2)
                .Index(t => t.Livro)
                .Index(t => t.Usuarios_Id)
                .Index(t => t.Usuarios_Id1)
                .Index(t => t.Usuarios_Id2);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100, unicode: false),
                        Login = c.String(nullable: false, maxLength: 50, unicode: false),
                        Senha = c.String(nullable: false, maxLength: 50, unicode: false),
                        Email = c.String(nullable: false, maxLength: 100, unicode: false),
                        Ativo = c.Boolean(),
                        UsuInc = c.Int(),
                        UsuAlt = c.Int(),
                        DatInc = c.DateTime(),
                        DatAlt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LivroAutor",
                c => new
                    {
                        Autor = c.Int(nullable: false),
                        Livro = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Autor, t.Livro })
                .ForeignKey("dbo.Autores", t => t.Autor, cascadeDelete: true)
                .ForeignKey("dbo.Livros", t => t.Livro, cascadeDelete: true)
                .Index(t => t.Autor)
                .Index(t => t.Livro);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Locacao", "Usuarios_Id2", "dbo.Usuarios");
            DropForeignKey("dbo.Locacao", "Usuarios_Id1", "dbo.Usuarios");
            DropForeignKey("dbo.Locacao", "Usuarios_Id", "dbo.Usuarios");
            DropForeignKey("dbo.Livros", "Usuarios_Id1", "dbo.Usuarios");
            DropForeignKey("dbo.Livros", "Usuarios_Id", "dbo.Usuarios");
            DropForeignKey("dbo.LivroAutor", "Livro", "dbo.Livros");
            DropForeignKey("dbo.LivroAutor", "Autor", "dbo.Autores");
            DropForeignKey("dbo.Locacao", "Livro", "dbo.Livros");
            DropForeignKey("dbo.Livros", "Genero", "dbo.Generos");
            DropForeignKey("dbo.Livros", "Editora", "dbo.Editoras");
            DropIndex("dbo.LivroAutor", new[] { "Livro" });
            DropIndex("dbo.LivroAutor", new[] { "Autor" });
            DropIndex("dbo.Locacao", new[] { "Usuarios_Id2" });
            DropIndex("dbo.Locacao", new[] { "Usuarios_Id1" });
            DropIndex("dbo.Locacao", new[] { "Usuarios_Id" });
            DropIndex("dbo.Locacao", new[] { "Livro" });
            DropIndex("dbo.Livros", new[] { "Usuarios_Id1" });
            DropIndex("dbo.Livros", new[] { "Usuarios_Id" });
            DropIndex("dbo.Livros", new[] { "Editora" });
            DropIndex("dbo.Livros", new[] { "Genero" });
            DropTable("dbo.LivroAutor");
            DropTable("dbo.Usuarios");
            DropTable("dbo.Locacao");
            DropTable("dbo.Generos");
            DropTable("dbo.Editoras");
            DropTable("dbo.Livros");
            DropTable("dbo.Autores");
        }
    }
}
