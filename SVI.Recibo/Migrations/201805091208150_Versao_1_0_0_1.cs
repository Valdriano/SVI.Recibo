namespace SVI.Recibo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Versao_1_0_0_1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Fornecedores", "Logo", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Fornecedores", "Logo");
        }
    }
}
