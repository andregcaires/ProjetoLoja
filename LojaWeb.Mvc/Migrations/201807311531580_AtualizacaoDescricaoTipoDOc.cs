namespace LojaWeb.Mvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AtualizacaoDescricaoTipoDOc : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TipoDocumentoes", "Descricao", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TipoDocumentoes", "Descricao", c => c.Int(nullable: false));
        }
    }
}
