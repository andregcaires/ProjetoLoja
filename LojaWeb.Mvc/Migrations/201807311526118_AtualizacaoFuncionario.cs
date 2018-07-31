namespace LojaWeb.Mvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AtualizacaoFuncionario : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Funcionarios", "TipoDocumento_TipoDocumentoId", "dbo.TipoDocumentoes");
            DropIndex("dbo.Funcionarios", new[] { "TipoDocumento_TipoDocumentoId" });
            RenameColumn(table: "dbo.Funcionarios", name: "TipoDocumento_TipoDocumentoId", newName: "TipoDocumentoId");
            AlterColumn("dbo.Funcionarios", "Nome", c => c.String(nullable: false, maxLength: 70));
            AlterColumn("dbo.Funcionarios", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Funcionarios", "TipoDocumentoId", c => c.Int(nullable: false));
            CreateIndex("dbo.Funcionarios", "TipoDocumentoId");
            AddForeignKey("dbo.Funcionarios", "TipoDocumentoId", "dbo.TipoDocumentoes", "TipoDocumentoId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Funcionarios", "TipoDocumentoId", "dbo.TipoDocumentoes");
            DropIndex("dbo.Funcionarios", new[] { "TipoDocumentoId" });
            AlterColumn("dbo.Funcionarios", "TipoDocumentoId", c => c.Int());
            AlterColumn("dbo.Funcionarios", "Email", c => c.String());
            AlterColumn("dbo.Funcionarios", "Nome", c => c.String());
            RenameColumn(table: "dbo.Funcionarios", name: "TipoDocumentoId", newName: "TipoDocumento_TipoDocumentoId");
            CreateIndex("dbo.Funcionarios", "TipoDocumento_TipoDocumentoId");
            AddForeignKey("dbo.Funcionarios", "TipoDocumento_TipoDocumentoId", "dbo.TipoDocumentoes", "TipoDocumentoId");
        }
    }
}
