namespace SAGA.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addColectionContactoReferenciado : DbMigration
    {
        public override void Up()
        {
            AddColumn("sist.Contactos", "ClienteId", c => c.Guid(nullable: false));
            AddColumn("sist.Referenciados", "Clave", c => c.String(nullable: false, maxLength: 100));
            AddColumn("sist.Referenciados", "ClienteId", c => c.Guid(nullable: false));
            CreateIndex("sist.Contactos", "ClienteId");
            CreateIndex("sist.Referenciados", "ClienteId");
            AddForeignKey("sist.Contactos", "ClienteId", "sist.Clientes", "Id");
            AddForeignKey("sist.Referenciados", "ClienteId", "sist.Clientes", "Id");
            DropColumn("sist.Referenciados", "DAL");
        }
        
        public override void Down()
        {
            AddColumn("sist.Referenciados", "DAL", c => c.String(nullable: false, maxLength: 100));
            DropForeignKey("sist.Referenciados", "ClienteId", "sist.Clientes");
            DropForeignKey("sist.Contactos", "ClienteId", "sist.Clientes");
            DropIndex("sist.Referenciados", new[] { "ClienteId" });
            DropIndex("sist.Contactos", new[] { "ClienteId" });
            DropColumn("sist.Referenciados", "ClienteId");
            DropColumn("sist.Referenciados", "Clave");
            DropColumn("sist.Contactos", "ClienteId");
        }
    }
}
