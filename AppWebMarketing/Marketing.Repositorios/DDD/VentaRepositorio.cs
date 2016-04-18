using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Marketing.Repositorios.Dominio;

namespace Marketing.Repositorios.DDD
{
    public class VentaRepositorio : GenericRepository<EFMarketingRepository, Venta>
    {
        public VentaRepositorio(EFMarketingRepository context) : base(context)
        {

        }
    }
}
