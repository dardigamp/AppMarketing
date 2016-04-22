namespace Marketing.Repositorios.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicio : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Campanas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                        FechaInicio = c.DateTime(nullable: false),
                        FechaFin = c.DateTime(nullable: false),
                        Estado = c.String(maxLength: 1, fixedLength: true, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ventas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false),
                        Monto = c.Double(nullable: false),
                        Impuestos = c.Double(nullable: false),
                        Total = c.Double(nullable: false),
                        IdCliente = c.Int(nullable: false),
                        IdCampana = c.Int(nullable: false),
                        Campana_Id = c.Int(),
                        Cliente_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Campanas", t => t.Campana_Id)
                .ForeignKey("dbo.Clientes", t => t.Cliente_Id)
                .Index(t => t.Campana_Id)
                .Index(t => t.Cliente_Id);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RazonSocial = c.String(),
                        RUC = c.String(),
                        Direccion = c.String(),
                        Ubigeo = c.String(),
                        Correo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DetalleVentas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cantidad = c.Int(nullable: false),
                        SubTotal = c.Double(nullable: false),
                        IdVenta = c.Int(nullable: false),
                        SKU = c.Int(nullable: false),
                        Venta_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Productoes", t => t.SKU, cascadeDelete: true)
                .ForeignKey("dbo.Ventas", t => t.Venta_Id)
                .Index(t => t.SKU)
                .Index(t => t.Venta_Id);
            
            CreateTable(
                "dbo.Productoes",
                c => new
                    {
                        SKU = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                        UnidadMedida = c.String(),
                        Stock = c.Int(nullable: false),
                        Talla = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SKU);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DetalleVentas", "Venta_Id", "dbo.Ventas");
            DropForeignKey("dbo.DetalleVentas", "SKU", "dbo.Productoes");
            DropForeignKey("dbo.Ventas", "Cliente_Id", "dbo.Clientes");
            DropForeignKey("dbo.Ventas", "Campana_Id", "dbo.Campanas");
            DropIndex("dbo.DetalleVentas", new[] { "Venta_Id" });
            DropIndex("dbo.DetalleVentas", new[] { "SKU" });
            DropIndex("dbo.Ventas", new[] { "Cliente_Id" });
            DropIndex("dbo.Ventas", new[] { "Campana_Id" });
            DropTable("dbo.Productoes");
            DropTable("dbo.DetalleVentas");
            DropTable("dbo.Clientes");
            DropTable("dbo.Ventas");
            DropTable("dbo.Campanas");
        }
    }
}
