using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Marketing.Repositorios.Dominio;

namespace Marketing.Repositorios.DDD
{
    public interface IMarketingRepository : IDisposable
    {
        IGenericRepository<Cliente> ClienteRepository { get; }
        IGenericRepository<Campana> CampanaRepository { get; }
        IGenericRepository<Producto> ProductoRepository { get; }
        IGenericRepository<Venta> VentaRepository { get; }
        IGenericRepository<DetalleVenta> DetalleVentaRepository  { get; }        
        void Commit();
    }
}
