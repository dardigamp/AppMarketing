using Marketing.Repositorios.Dominio;

namespace Marketing.Repositorios.DDD
{
    public class VisitaRepositorio : GenericRepository<EFMarketingRepository, Visita>
    {
        public VisitaRepositorio(EFMarketingRepository context) : base(context)
        {

        }
    }
}
