namespace DatosPRG.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Empleado",
                c => new
                    {
                        PersonaId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        Apellido = c.String(),
                    })
                .PrimaryKey(t => t.PersonaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Empleado");
        }
    }
}
