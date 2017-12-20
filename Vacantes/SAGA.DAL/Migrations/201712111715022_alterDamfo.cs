namespace SAGA.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alterDamfo : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("sist.RutasPerfil", "DAMFO_290_Id", "sist.DAMFO_290");
            DropIndex("sist.RutasPerfil", new[] { "DAMFO_290_Id" });
            DropColumn("sist.RutasPerfil", "DAMFO_290_Id");
        }
        
        public override void Down()
        {
            AddColumn("sist.RutasPerfil", "DAMFO_290_Id", c => c.Guid());
            CreateIndex("sist.RutasPerfil", "DAMFO_290_Id");
            AddForeignKey("sist.RutasPerfil", "DAMFO_290_Id", "sist.DAMFO_290", "Id");
        }
    }
}
