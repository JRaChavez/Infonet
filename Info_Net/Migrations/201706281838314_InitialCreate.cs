namespace Info_Net.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Publications",
                c => new
                    {
                        Publication_id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Titulo = c.String(),
                        Description = c.String(),
                        Imagen = c.String(),
                        Contenido = c.String(),
                    })
                .PrimaryKey(t => t.Publication_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Publications");
        }
    }
}
