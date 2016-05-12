namespace Marketing.Repositorios.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class otrastablas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comentarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false),
                        Descripcion = c.String(),
                        Visita_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Visitas", t => t.Visita_Id)
                .Index(t => t.Visita_Id);
            
            CreateTable(
                "dbo.Visitas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false),
                        Observacion = c.String(),
                        Stand_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Stands", t => t.Stand_Id)
                .Index(t => t.Stand_Id);
            
            CreateTable(
                "dbo.FotoVisitas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ruta = c.String(),
                        Stand_Id = c.Int(),
                        Visita_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Stands", t => t.Stand_Id)
                .ForeignKey("dbo.Visitas", t => t.Visita_Id)
                .Index(t => t.Stand_Id)
                .Index(t => t.Visita_Id);
            
            CreateTable(
                "dbo.Stands",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        Tamano = c.String(),
                        Plano = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FotoStands",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ruta = c.String(),
                        Stand_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Stands", t => t.Stand_Id)
                .Index(t => t.Stand_Id);
            
            CreateTable(
                "dbo.Ubicacions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Fotografia = c.String(),
                        Stand_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Stands", t => t.Stand_Id)
                .Index(t => t.Stand_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FotoVisitas", "Visita_Id", "dbo.Visitas");
            DropForeignKey("dbo.FotoVisitas", "Stand_Id", "dbo.Stands");
            DropForeignKey("dbo.Visitas", "Stand_Id", "dbo.Stands");
            DropForeignKey("dbo.Ubicacions", "Stand_Id", "dbo.Stands");
            DropForeignKey("dbo.FotoStands", "Stand_Id", "dbo.Stands");
            DropForeignKey("dbo.Comentarios", "Visita_Id", "dbo.Visitas");
            DropIndex("dbo.Ubicacions", new[] { "Stand_Id" });
            DropIndex("dbo.FotoStands", new[] { "Stand_Id" });
            DropIndex("dbo.FotoVisitas", new[] { "Visita_Id" });
            DropIndex("dbo.FotoVisitas", new[] { "Stand_Id" });
            DropIndex("dbo.Visitas", new[] { "Stand_Id" });
            DropIndex("dbo.Comentarios", new[] { "Visita_Id" });
            DropTable("dbo.Ubicacions");
            DropTable("dbo.FotoStands");
            DropTable("dbo.Stands");
            DropTable("dbo.FotoVisitas");
            DropTable("dbo.Visitas");
            DropTable("dbo.Comentarios");
        }
    }
}
