namespace Marketing.Repositorios.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TablaStand : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Stands", "Campana_Id", c => c.Int());
            AddColumn("dbo.Stands", "Cliente_Id", c => c.Int());
            CreateIndex("dbo.Stands", "Campana_Id");
            CreateIndex("dbo.Stands", "Cliente_Id");
            AddForeignKey("dbo.Stands", "Campana_Id", "dbo.Campanas", "Id");
            AddForeignKey("dbo.Stands", "Cliente_Id", "dbo.Clientes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Stands", "Cliente_Id", "dbo.Clientes");
            DropForeignKey("dbo.Stands", "Campana_Id", "dbo.Campanas");
            DropIndex("dbo.Stands", new[] { "Cliente_Id" });
            DropIndex("dbo.Stands", new[] { "Campana_Id" });
            DropColumn("dbo.Stands", "Cliente_Id");
            DropColumn("dbo.Stands", "Campana_Id");
        }
    }
}
