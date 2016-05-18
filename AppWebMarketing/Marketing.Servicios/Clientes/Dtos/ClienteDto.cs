using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketing.Servicios.Clientes.Dtos
{
    public class ClienteDto
    {
        public int Id { get; set; }
        public string RazonSocial { get; set; }
        public string RUC { get; set; }
        public string Direccion { get; set; }
        public string Ubigeo { get; set; }
        public string Correo { get; set; }
    }
}
