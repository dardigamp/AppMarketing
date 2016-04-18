using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketing.Repositorios.Dominio
{
    public class Venta : Entidad
    {
        public DateTime Fecha { get; set; }
        public double Monto { get; set; }
        public double Impuestos { get; set; }
        public double Total { get; set; }
        public char Estado  { get; set; }
        public int IdCliente { get; set; }
        public int IdCampana { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Campana Campana { get; set; }
    }
}
