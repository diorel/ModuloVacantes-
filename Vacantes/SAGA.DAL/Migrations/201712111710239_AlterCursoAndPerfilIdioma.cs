namespace SAGA.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterCursoAndPerfilIdioma : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "sist.PerfilIdiomas", name: "NivelId", newName: "NivelEscritoId");
            RenameIndex(table: "sist.PerfilIdiomas", name: "IX_NivelId", newName: "IX_NivelEscritoId");
            AddColumn("sist.Cursos", "Horas", c => c.Int());
            AddColumn("sist.PerfilIdiomas", "NivelHabladoId", c => c.Byte(nullable: false));
            CreateIndex("sist.PerfilIdiomas", "NivelHabladoId");
            AddForeignKey("sist.PerfilIdiomas", "NivelHabladoId", "sist.Niveles", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("sist.PerfilIdiomas", "NivelHabladoId", "sist.Niveles");
            DropIndex("sist.PerfilIdiomas", new[] { "NivelHabladoId" });
            DropColumn("sist.PerfilIdiomas", "NivelHabladoId");
            DropColumn("sist.Cursos", "Horas");
            RenameIndex(table: "sist.PerfilIdiomas", name: "IX_NivelEscritoId", newName: "IX_NivelId");
            RenameColumn(table: "sist.PerfilIdiomas", name: "NivelEscritoId", newName: "NivelId");
        }
    }
}
