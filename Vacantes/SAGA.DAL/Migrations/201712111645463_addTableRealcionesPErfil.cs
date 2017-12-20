namespace SAGA.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTableRealcionesPErfil : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "sist.PsicometriasClientes", newName: "PsicometriasCliente");
            RenameTable(name: "sist.PsicometriasDamsas", newName: "PsicometriasDamsa");
            AlterColumn("sist.PsicometriasCliente", "Psicometria", c => c.String(maxLength: 50));
            AlterColumn("sist.PsicometriasCliente", "Descripcion", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("sist.PsicometriasCliente", "Descripcion", c => c.String());
            AlterColumn("sist.PsicometriasCliente", "Psicometria", c => c.String());
            RenameTable(name: "sist.PsicometriasDamsa", newName: "PsicometriasDamsas");
            RenameTable(name: "sist.PsicometriasCliente", newName: "PsicometriasClientes");
        }
    }
}
