using Marketing.Repositorios.Dominio;

namespace Marketing.Repositorios.DDD
{
    public class FotoStandRepositorio : GenericRepository<EFMarketingRepository, FotoStand>
    {
        public FotoStandRepositorio(EFMarketingRepository context) : base(context)
        {

        }
    }
}
