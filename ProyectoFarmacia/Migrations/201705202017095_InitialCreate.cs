namespace ProyectoFarmacia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        Nombres = c.String(nullable: false, maxLength: 100),
                        Direccion = c.String(nullable: false, maxLength: 100),
                        Telefono = c.String(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                        Email = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.ClienteId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Clientes");
        }
    }
}
