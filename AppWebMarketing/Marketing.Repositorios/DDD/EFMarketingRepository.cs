using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Marketing.Repositorios.Dominio;
using Marketing.Repositorios.DDD;

namespace Marketing.Repositorios.DDD
{
    public class EFMarketingRepository : DbContext, IMarketingRepository
    {
        private readonly ClienteRepositorio _clienteRepo;
        private readonly CampanaRepositorio _campanaRepo;
        private readonly ProductoRespositorio _productoRepo;
        private readonly VentaRepositorio _ventaRepo;
        private readonly DetalleVentaRepositorio _detalleVentaRepo;

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Campana> Campanas { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<DetalleVenta> DetallesVenta { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public EFMarketingRepository()
            : base("AMarketing")
        {
            _clienteRepo = new ClienteRepositorio(this);
            _campanaRepo = new CampanaRepositorio(this);
            _productoRepo = new ProductoRespositorio(this);
            _ventaRepo = new VentaRepositorio(this);
            _detalleVentaRepo = new DetalleVentaRepositorio(this);
        }

        public void Commit()
        {
            this.SaveChanges();
        }

        public IGenericRepository<Cliente> ClienteRepository
        {
            get
            { return _clienteRepo; }
        }


        public IGenericRepository<Campana> CampanaRepository
        {
            get { return _campanaRepo; }
        }

        public IGenericRepository<Producto> ProductoRepository
        {
            get { return _productoRepo; }
        }

        public IGenericRepository<Venta> VentaRepository
        {
            get { return _ventaRepo; }
        }

        public IGenericRepository<DetalleVenta> DetalleVentaRepository
        {
            get { return _detalleVentaRepo; }
        }
    }
}
