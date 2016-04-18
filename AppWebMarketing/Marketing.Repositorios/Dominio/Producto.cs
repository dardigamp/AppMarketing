using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Marketing.Repositorios.Dominio
{
    public class Producto
    {
        [Key]
        public int SKU { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string UnidadMedida { get; set; }
        public int Stock { get; set; }
        public int Talla { get; set; }
    }
}
