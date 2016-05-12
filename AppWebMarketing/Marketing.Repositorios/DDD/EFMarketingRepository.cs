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
        private readonly StandRepositorio _standRepo;
        private readonly UbicacionRepositorio _ubicacionRepo;
        private readonly FotoStandRepositorio _fotoStandRepo;
        private readonly VisitaRepositorio _visitaRepo;
        private readonly FotoVisitaRepositorio _fotoVisitaRepo;
        private readonly ComentarioRepositorio _comentarioRepo;

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Campana> Campanas { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<DetalleVenta> DetallesVenta { get; set; }

        public DbSet<Stand> Stands { get; set; }
        public DbSet<Ubicacion> Ubicaciones { get; set; }
        public DbSet<FotoStand> FotosStand { get; set; }
        public DbSet<Visita> Visitas { get; set; }
        public DbSet<FotoVisita> FotosVisitas { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }

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

            _standRepo = new StandRepositorio(this);
            _ubicacionRepo = new UbicacionRepositorio(this);
            _fotoStandRepo = new FotoStandRepositorio(this);
            _visitaRepo = new VisitaRepositorio(this);
            _fotoVisitaRepo = new FotoVisitaRepositorio(this);
            _comentarioRepo = new ComentarioRepositorio(this);

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

        public IGenericRepository<Stand> StandRepository
        {
            get { return _standRepo; }
        }

        public IGenericRepository<FotoStand> FotoStandRepository
        {
            get { return _fotoStandRepo; }
        }

        public IGenericRepository<Ubicacion> UbicacionRepository
        {
            get {
                return _ubicacionRepo; }
        }

        public IGenericRepository<Visita> VisitaRepository
        {
            get { return _visitaRepo; }
        }

        public IGenericRepository<FotoVisita> FotoVisitaRepository
        {
            get { return _fotoVisitaRepo; }
        }

        public IGenericRepository<Comentario> ComentarioRepository
        {
            get { return _comentarioRepo; }
        }
    }
}
