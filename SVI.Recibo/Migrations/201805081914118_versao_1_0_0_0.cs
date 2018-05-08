namespace SVI.Recibo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class versao_1_0_0_0 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Configuracoes",
                c => new
                    {
                        IDConfiguracao = c.Int(nullable: false, identity: true),
                        Licenca = c.String(maxLength: 255),
                        Proprietario = c.String(nullable: false, maxLength: 40),
                        Email = c.String(maxLength: 100),
                        Local = c.String(nullable: false, maxLength: 40),
                    })
                .PrimaryKey(t => t.IDConfiguracao);
            
            CreateTable(
                "dbo.Fornecedores",
                c => new
                    {
                        IDFornecedor = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 60),
                        CPFCNPJ = c.Long(nullable: false),
                        Bairro = c.String(nullable: false, maxLength: 60),
                        Lougradouro = c.String(nullable: false, maxLength: 60),
                        Numero = c.String(maxLength: 10),
                        Complemento = c.String(maxLength: 150),
                        CEP = c.Int(),
                    })
                .PrimaryKey(t => t.IDFornecedor);
            
            CreateTable(
                "dbo.Recibos",
                c => new
                    {
                        IDRecibo = c.Int(nullable: false, identity: true),
                        IDFornecedor = c.Int(nullable: false),
                        DataHora = c.DateTime(nullable: false),
                        Valor = c.Decimal(nullable: false, precision: 13, scale: 4),
                        Referencia = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.IDRecibo)
                .ForeignKey("dbo.Fornecedores", t => t.IDFornecedor, cascadeDelete: true)
                .Index(t => t.IDFornecedor);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Recibos", "IDFornecedor", "dbo.Fornecedores");
            DropIndex("dbo.Recibos", new[] { "IDFornecedor" });
            DropTable("dbo.Recibos");
            DropTable("dbo.Fornecedores");
            DropTable("dbo.Configuracoes");
        }
    }
}
