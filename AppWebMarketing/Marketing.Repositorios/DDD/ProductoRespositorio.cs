using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Marketing.Repositorios.Dominio;

namespace Marketing.Repositorios.DDD
{
    public class ProductoRespositorio : GenericRepository<EFMarketingRepository, Producto>
    {
        public ProductoRespositorio(EFMarketingRepository context) : base(context)
        {

        }
    }
}
