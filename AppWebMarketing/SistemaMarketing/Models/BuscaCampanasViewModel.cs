using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaMarketing.Models
{
    public class BuscaCampanasViewModel
    {
        public BuscaCampanasViewModel()
        {
            Campanas = new List<CampanaViewModel>();
        }
        public string Busqueda { get; set; }
        public IEnumerable<CampanaViewModel> Campanas { get; set; }
    }
}