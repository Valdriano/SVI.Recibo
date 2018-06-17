namespace SVI.Recibo.Infra.Migrations
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
                        Licenca = c.String(maxLength: 255),
                        Proprietario = c.String(nullable: false, maxLength: 60),
                        Email = c.String(nullable: false, maxLength: 100),
                        IdEstado = c.Int(nullable: false),
                        IdMunicipio = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Estados", t => t.IdEstado, cascadeDelete: true)
                .ForeignKey("dbo.Municipios", t => t.IdMunicipio, cascadeDelete: true)
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
                "dbo.Municipios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 40),
                        IdEstado = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Estados", t => t.IdEstado, cascadeDelete: true)
                .Index(t => t.IdEstado);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Configuracoes", "IdMunicipio", "dbo.Municipios");
            DropForeignKey("dbo.Configuracoes", "IdEstado", "dbo.Estados");
            DropForeignKey("dbo.Municipios", "IdEstado", "dbo.Estados");
            DropIndex("dbo.Municipios", new[] { "IdEstado" });
            DropIndex("dbo.Configuracoes", new[] { "IdMunicipio" });
            DropIndex("dbo.Configuracoes", new[] { "IdEstado" });
            DropTable("dbo.Municipios");
            DropTable("dbo.Estados");
            DropTable("dbo.Configuracoes");
        }
    }
}
