namespace SAGA.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alterTableRutasPerfil : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("sist.RutasPerfil", "DAMFO290Id", "sist.DAMFO_290");
            DropIndex("sist.RutasPerfil", new[] { "DAMFO290Id" });
            RenameColumn(table: "sist.RutasPerfil", name: "DAMFO290Id", newName: "DAMFO_290_Id");
            AlterColumn("sist.RutasPerfil", "DAMFO_290_Id", c => c.Guid());
            CreateIndex("sist.RutasPerfil", "DAMFO_290_Id");
            AddForeignKey("sist.RutasPerfil", "DAMFO_290_Id", "sist.DAMFO_290", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("sist.RutasPerfil", "DAMFO_290_Id", "sist.DAMFO_290");
            DropIndex("sist.RutasPerfil", new[] { "DAMFO_290_Id" });
            AlterColumn("sist.RutasPerfil", "DAMFO_290_Id", c => c.Guid(nullable: false));
            RenameColumn(table: "sist.RutasPerfil", name: "DAMFO_290_Id", newName: "DAMFO290Id");
            CreateIndex("sist.RutasPerfil", "DAMFO290Id");
            AddForeignKey("sist.RutasPerfil", "DAMFO290Id", "sist.DAMFO_290", "Id", cascadeDelete: true);
        }
    }
}
