namespace Info_Net.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _20172806 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Publications", "Nombre", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Publications", "Titulo", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Publications", "Description", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Publications", "Imagen", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Publications", "Contenido", c => c.String(nullable: false, maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Publications", "Contenido", c => c.String());
            AlterColumn("dbo.Publications", "Imagen", c => c.String());
            AlterColumn("dbo.Publications", "Description", c => c.String());
            AlterColumn("dbo.Publications", "Titulo", c => c.String());
            AlterColumn("dbo.Publications", "Nombre", c => c.String());
        }
    }
}
