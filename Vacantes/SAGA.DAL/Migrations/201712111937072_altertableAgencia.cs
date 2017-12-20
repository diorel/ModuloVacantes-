namespace SAGA.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class altertableAgencia : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("sist.Agencias", "PersonaId", "sist.Personas");
            DropIndex("sist.Agencias", new[] { "PersonaId" });
            AddColumn("sist.Agencias", "ClienteId", c => c.Guid(nullable: false));
            CreateIndex("sist.Agencias", "ClienteId");
            AddForeignKey("sist.Agencias", "ClienteId", "sist.Clientes", "Id");
            DropColumn("sist.Agencias", "PersonaId");
        }
        
        public override void Down()
        {
            AddColumn("sist.Agencias", "PersonaId", c => c.Guid(nullable: false));
            DropForeignKey("sist.Agencias", "ClienteId", "sist.Clientes");
            DropIndex("sist.Agencias", new[] { "ClienteId" });
            DropColumn("sist.Agencias", "ClienteId");
            CreateIndex("sist.Agencias", "PersonaId");
            AddForeignKey("sist.Agencias", "PersonaId", "sist.Personas", "Id", cascadeDelete: true);
        }
    }
}
