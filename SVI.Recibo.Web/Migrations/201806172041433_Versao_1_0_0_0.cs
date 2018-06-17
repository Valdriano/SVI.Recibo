namespace SVI.Recibo.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Versao_1_0_0_0 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Configuracoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Proprietario = c.String(nullable: false, maxLength: 60),
                        Email = c.String(maxLength: 100),
                        CPF = c.Long(),
                        CNPJ = c.Long(),
                        Licenca = c.String(nullable: false, maxLength: 255),
                        IdEstado = c.Int(nullable: false),
                        IdMunicipio = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Estados", t => t.IdEstado)
                .ForeignKey("dbo.Municipios", t => t.IdMunicipio)
                .Index(t => t.IdEstado)
                .Index(t => t.IdMunicipio);
            
            CreateTable(
                "dbo.Estados",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 40),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Fornecedores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 40),
                        Fantasia = c.String(maxLength: 40),
                        CPF = c.Long(),
                        CNPJ = c.Long(),
                        CEP = c.Int(),
                        Bairro = c.String(nullable: false, maxLength: 40),
                        Logradouro = c.String(nullable: false, maxLength: 40),
                        Numero = c.String(nullable: false, maxLength: 10),
                        Complemento = c.String(maxLength: 40),
                        IdEstado = c.Int(nullable: false),
                        IdMunicipio = c.Int(nullable: false),
                        Logo = c.Binary(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Estados", t => t.IdEstado)
                .ForeignKey("dbo.Municipios", t => t.IdMunicipio)
                .Index(t => t.IdEstado)
                .Index(t => t.IdMunicipio);
            
            CreateTable(
                "dbo.Municipios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(maxLength: 40),
                        IdEstado = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Estados", t => t.IdEstado)
                .Index(t => t.IdEstado);
            
            CreateTable(
                "dbo.Recibos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdFornecedor = c.Int(nullable: false),
                        Valor = c.Decimal(nullable: false, precision: 13, scale: 4),
                        Referencia = c.String(nullable: false, maxLength: 100),
                        Data = c.DateTime(nullable: false),
                        IdEstado = c.Int(nullable: false),
                        IdMunicipio = c.Int(nullable: false),
                        QuantidadeImpressao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Estados", t => t.IdEstado)
                .ForeignKey("dbo.Fornecedores", t => t.IdFornecedor)
                .ForeignKey("dbo.Municipios", t => t.IdMunicipio)
                .Index(t => t.IdFornecedor)
                .Index(t => t.IdEstado)
                .Index(t => t.IdMunicipio);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Configuracoes", "IdMunicipio", "dbo.Municipios");
            DropForeignKey("dbo.Configuracoes", "IdEstado", "dbo.Estados");
            DropForeignKey("dbo.Fornecedores", "IdMunicipio", "dbo.Municipios");
            DropForeignKey("dbo.Recibos", "IdMunicipio", "dbo.Municipios");
            DropForeignKey("dbo.Recibos", "IdFornecedor", "dbo.Fornecedores");
            DropForeignKey("dbo.Recibos", "IdEstado", "dbo.Estados");
            DropForeignKey("dbo.Municipios", "IdEstado", "dbo.Estados");
            DropForeignKey("dbo.Fornecedores", "IdEstado", "dbo.Estados");
            DropIndex("dbo.Recibos", new[] { "IdMunicipio" });
            DropIndex("dbo.Recibos", new[] { "IdEstado" });
            DropIndex("dbo.Recibos", new[] { "IdFornecedor" });
            DropIndex("dbo.Municipios", new[] { "IdEstado" });
            DropIndex("dbo.Fornecedores", new[] { "IdMunicipio" });
            DropIndex("dbo.Fornecedores", new[] { "IdEstado" });
            DropIndex("dbo.Configuracoes", new[] { "IdMunicipio" });
            DropIndex("dbo.Configuracoes", new[] { "IdEstado" });
            DropTable("dbo.Recibos");
            DropTable("dbo.Municipios");
            DropTable("dbo.Fornecedores");
            DropTable("dbo.Estados");
            DropTable("dbo.Configuracoes");
        }
    }
}
