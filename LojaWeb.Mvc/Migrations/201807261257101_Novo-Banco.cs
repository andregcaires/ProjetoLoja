namespace LojaWeb.Mvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NovoBanco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Funcionarios",
                c => new
                    {
                        FuncionarioId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Email = c.String(),
                        Salario = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DataNascimento = c.DateTime(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        TipoDocumento_TipoDocumentoId = c.Int(),
                    })
                .PrimaryKey(t => t.FuncionarioId)
                .ForeignKey("dbo.TipoDocumentoes", t => t.TipoDocumento_TipoDocumentoId)
                .Index(t => t.TipoDocumento_TipoDocumentoId);
            
            CreateTable(
                "dbo.TipoDocumentoes",
                c => new
                    {
                        TipoDocumentoId = c.Int(nullable: false, identity: true),
                        Descricao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TipoDocumentoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Funcionarios", "TipoDocumento_TipoDocumentoId", "dbo.TipoDocumentoes");
            DropIndex("dbo.Funcionarios", new[] { "TipoDocumento_TipoDocumentoId" });
            DropTable("dbo.TipoDocumentoes");
            DropTable("dbo.Funcionarios");
        }
    }
}
