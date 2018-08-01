namespace LojaWeb.Mvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fornecedors",
                c => new
                    {
                        FornecedorId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Endereco = c.String(),
                        Email = c.String(),
                        Telefone = c.String(),
                    })
                .PrimaryKey(t => t.FornecedorId);
            
            CreateTable(
                "dbo.FornecedorProdutoes",
                c => new
                    {
                        FornecedorProdutoId = c.Int(nullable: false, identity: true),
                        FornecedorId = c.Int(nullable: false),
                        ProdutoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FornecedorProdutoId)
                .ForeignKey("dbo.Fornecedors", t => t.FornecedorId)
                .ForeignKey("dbo.Produtoes", t => t.ProdutoId)
                .Index(t => t.FornecedorId)
                .Index(t => t.ProdutoId);
            
            CreateTable(
                "dbo.Produtoes",
                c => new
                    {
                        ProdutoId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Preco = c.Decimal(nullable: false, precision: 18, scale: 2),
                        UltimaCompra = c.DateTime(nullable: false),
                        Estoque = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProdutoId);
            
            CreateTable(
                "dbo.Funcionarios",
                c => new
                    {
                        FuncionarioId = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 70),
                        Email = c.String(nullable: false),
                        Salario = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DataNascimento = c.DateTime(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        TipoDocumentoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FuncionarioId)
                .ForeignKey("dbo.TipoDocumentoes", t => t.TipoDocumentoId)
                .Index(t => t.TipoDocumentoId);
            
            CreateTable(
                "dbo.TipoDocumentoes",
                c => new
                    {
                        TipoDocumentoId = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.TipoDocumentoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Funcionarios", "TipoDocumentoId", "dbo.TipoDocumentoes");
            DropForeignKey("dbo.FornecedorProdutoes", "ProdutoId", "dbo.Produtoes");
            DropForeignKey("dbo.FornecedorProdutoes", "FornecedorId", "dbo.Fornecedors");
            DropIndex("dbo.Funcionarios", new[] { "TipoDocumentoId" });
            DropIndex("dbo.FornecedorProdutoes", new[] { "ProdutoId" });
            DropIndex("dbo.FornecedorProdutoes", new[] { "FornecedorId" });
            DropTable("dbo.TipoDocumentoes");
            DropTable("dbo.Funcionarios");
            DropTable("dbo.Produtoes");
            DropTable("dbo.FornecedorProdutoes");
            DropTable("dbo.Fornecedors");
        }
    }
}
