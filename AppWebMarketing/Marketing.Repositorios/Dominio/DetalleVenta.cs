using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketing.Repositorios.Dominio
{
    public class DetalleVenta : Entidad
    {        
        public int Cantidad { get; set; }
        public double SubTotal { get; set; }
        public char Estado { get; set; }
        public int IdVenta { get; set; }
        public int SKU { get; set; }
        public virtual Venta Venta { get; set; }
        public virtual Producto Producto { get; set; }
    }
}
