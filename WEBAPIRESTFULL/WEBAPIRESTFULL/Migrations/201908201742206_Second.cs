namespace WEBAPIRESTFULL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Livros", "Editora", "dbo.Editoras");
            DropForeignKey("dbo.Livros", "Genero", "dbo.Generos");
            DropIndex("dbo.Livros", new[] { "Genero" });
            DropIndex("dbo.Livros", new[] { "Editora" });
            AddColumn("dbo.Livros", "Editoras_Id", c => c.Int());
            AddColumn("dbo.Livros", "Generos_Id", c => c.Int());
            CreateIndex("dbo.Livros", "Editoras_Id");
            CreateIndex("dbo.Livros", "Generos_Id");
            AddForeignKey("dbo.Livros", "Editoras_Id", "dbo.Editoras", "Id");
            AddForeignKey("dbo.Livros", "Generos_Id", "dbo.Generos", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Livros", "Generos_Id", "dbo.Generos");
            DropForeignKey("dbo.Livros", "Editoras_Id", "dbo.Editoras");
            DropIndex("dbo.Livros", new[] { "Generos_Id" });
            DropIndex("dbo.Livros", new[] { "Editoras_Id" });
            DropColumn("dbo.Livros", "Generos_Id");
            DropColumn("dbo.Livros", "Editoras_Id");
            CreateIndex("dbo.Livros", "Editora");
            CreateIndex("dbo.Livros", "Genero");
            AddForeignKey("dbo.Livros", "Genero", "dbo.Generos", "Id");
            AddForeignKey("dbo.Livros", "Editora", "dbo.Editoras", "Id");
        }
    }
}
