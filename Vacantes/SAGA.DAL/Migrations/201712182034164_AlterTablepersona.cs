namespace SAGA.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterTablepersona : DbMigration
    {
        public override void Up()
        {
            AlterColumn("sist.Personas", "Nombre", c => c.String(maxLength: 50));
            AlterColumn("sist.Personas", "ApellidoPaterno", c => c.String(maxLength: 50));
            AlterColumn("sist.Personas", "ApellidoMaterno", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("sist.Personas", "ApellidoMaterno", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("sist.Personas", "ApellidoPaterno", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("sist.Personas", "Nombre", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
