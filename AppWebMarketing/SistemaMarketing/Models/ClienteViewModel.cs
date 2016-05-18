using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaMarketing.Models
{
    public class ClienteViewModel
    {
        public int Id { get; set; }
        public string RazonSocial { get; set; }
        public string RUC { get; set; }
        public string Direccion { get; set; }
        public string Ubigeo { get; set; }
        public string Correo { get; set; }
    }
}