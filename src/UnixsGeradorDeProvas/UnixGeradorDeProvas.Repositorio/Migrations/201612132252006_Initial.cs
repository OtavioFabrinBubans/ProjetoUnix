namespace UnixGeradorDeProvas.Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Funcoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Polo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Professor",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        PoloId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Polo", t => t.PoloId, cascadeDelete: false)
                .Index(t => t.PoloId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Professor", "PoloId", "dbo.Polo");
            DropIndex("dbo.Professor", new[] { "PoloId" });
            DropTable("dbo.Professor");
            DropTable("dbo.Polo");
            DropTable("dbo.Funcoes");
        }
    }
}
