using AutoMapper;
using Marketing.Repositorios.DDD;
using Marketing.Repositorios.Dominio;
using Marketing.Servicios.Stands.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketing.Servicios.Stands
{
    public class ServicioStands
    {
        private IMarketingRepository _contexto;

        public ServicioStands()
        {
            _contexto = new EFMarketingRepository();
        }

        public void Nuevo(StandDto standDto)
        {
            var stand = Mapper.Map<StandDto, Stand>(standDto);
            //repositorioCliente.Agregar(cliente);
            _contexto.StandRepository.Add(stand);
            _contexto.Commit();
        }
    }
}
