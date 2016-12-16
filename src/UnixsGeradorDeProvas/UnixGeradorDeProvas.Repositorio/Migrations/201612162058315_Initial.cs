namespace UnixGeradorDeProvas.Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dificuldade",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Disciplina",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pessoa",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
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
                "dbo.Questao",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DisciplinaInt = c.Int(nullable: false),
                        DificuldadeId = c.Int(nullable: false),
                        NumSemana = c.Int(nullable: false),
                        TemConsulta = c.Boolean(nullable: false),
                        TipoQuestaoInt = c.Int(nullable: false),
                        Enunciado = c.String(),
                        StatusQuestaoId = c.Int(nullable: false),
                        QtdUso = c.Int(nullable: false),
                        Disciplina_Id = c.Int(),
                        TipoQuestao_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Dificuldade", t => t.DificuldadeId, cascadeDelete: true)
                .ForeignKey("dbo.Disciplina", t => t.Disciplina_Id)
                .ForeignKey("dbo.StatusQuestao", t => t.StatusQuestaoId, cascadeDelete: true)
                .ForeignKey("dbo.TipoQuestao", t => t.TipoQuestao_Id)
                .Index(t => t.DificuldadeId)
                .Index(t => t.StatusQuestaoId)
                .Index(t => t.Disciplina_Id)
                .Index(t => t.TipoQuestao_Id);
            
            CreateTable(
                "dbo.StatusQuestao",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TipoQuestao",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PessoaDisciplina",
                c => new
                    {
                        Pessoa_Id = c.Int(nullable: false),
                        Disciplina_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Pessoa_Id, t.Disciplina_Id })
                .ForeignKey("dbo.Pessoa", t => t.Pessoa_Id, cascadeDelete: true)
                .ForeignKey("dbo.Disciplina", t => t.Disciplina_Id, cascadeDelete: true)
                .Index(t => t.Pessoa_Id)
                .Index(t => t.Disciplina_Id);
            
            CreateTable(
                "dbo.FuncoesPessoa",
                c => new
                    {
                        Funcoes_Id = c.Int(nullable: false),
                        Pessoa_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Funcoes_Id, t.Pessoa_Id })
                .ForeignKey("dbo.Funcoes", t => t.Funcoes_Id, cascadeDelete: true)
                .ForeignKey("dbo.Pessoa", t => t.Pessoa_Id, cascadeDelete: true)
                .Index(t => t.Funcoes_Id)
                .Index(t => t.Pessoa_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Questao", "TipoQuestao_Id", "dbo.TipoQuestao");
            DropForeignKey("dbo.Questao", "StatusQuestaoId", "dbo.StatusQuestao");
            DropForeignKey("dbo.Questao", "Disciplina_Id", "dbo.Disciplina");
            DropForeignKey("dbo.Questao", "DificuldadeId", "dbo.Dificuldade");
            DropForeignKey("dbo.FuncoesPessoa", "Pessoa_Id", "dbo.Pessoa");
            DropForeignKey("dbo.FuncoesPessoa", "Funcoes_Id", "dbo.Funcoes");
            DropForeignKey("dbo.PessoaDisciplina", "Disciplina_Id", "dbo.Disciplina");
            DropForeignKey("dbo.PessoaDisciplina", "Pessoa_Id", "dbo.Pessoa");
            DropIndex("dbo.FuncoesPessoa", new[] { "Pessoa_Id" });
            DropIndex("dbo.FuncoesPessoa", new[] { "Funcoes_Id" });
            DropIndex("dbo.PessoaDisciplina", new[] { "Disciplina_Id" });
            DropIndex("dbo.PessoaDisciplina", new[] { "Pessoa_Id" });
            DropIndex("dbo.Questao", new[] { "TipoQuestao_Id" });
            DropIndex("dbo.Questao", new[] { "Disciplina_Id" });
            DropIndex("dbo.Questao", new[] { "StatusQuestaoId" });
            DropIndex("dbo.Questao", new[] { "DificuldadeId" });
            DropTable("dbo.FuncoesPessoa");
            DropTable("dbo.PessoaDisciplina");
            DropTable("dbo.TipoQuestao");
            DropTable("dbo.StatusQuestao");
            DropTable("dbo.Questao");
            DropTable("dbo.Polo");
            DropTable("dbo.Funcoes");
            DropTable("dbo.Pessoa");
            DropTable("dbo.Disciplina");
            DropTable("dbo.Dificuldade");
        }
    }
}
