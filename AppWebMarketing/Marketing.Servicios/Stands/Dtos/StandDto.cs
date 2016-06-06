using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketing.Servicios.Stands.Dtos
{
    public class StandDto
    {
        public int Id { get; set; }
        public String Descripcion { get; set; }
        public String Tamano { get; set; }
        public String Plano { get; set; }
        public int Campaña { get; set; }
        public int Cliente { get; set; }
    }
}
