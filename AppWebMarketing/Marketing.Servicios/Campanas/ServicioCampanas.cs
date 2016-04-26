using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Marketing.Repositorios.DDD;
using Marketing.Repositorios.Dominio;
using Marketing.Servicios.Campanas.Dtos;
using AutoMapper;

namespace Marketing.Servicios.Campanas
{
    public class ServicioCampanas
    {
        private IMarketingRepository _contexto;

        public ServicioCampanas()
        {
            _contexto = new EFMarketingRepository();
        }

        //public void Nuevo(GrabaCampanaDto grabaCampanaDto)
        //{
        //    var campana = Mapper.Map<GrabaCampanaDto, Campana>(grabaCampanaDto);
        //    //repositorioCliente.Agregar(cliente);
        //    _contexto.CampanaRepository.Add(campana);
        //    _contexto.Commit();
        //}

        public void Nuevo(CampanaDto campanaDto)
        {
            var campana = Mapper.Map<CampanaDto, Campana>(campanaDto);
            //repositorioCliente.Agregar(cliente);
            _contexto.CampanaRepository.Add(campana);
            _contexto.Commit();
        }

        public CampanaDto TraerPorId(int id)
        {
            var campana = _contexto.CampanaRepository                
                .SingleOrDefault(x => x.Id == id);
            return Mapper.Map<Campana, CampanaDto>(campana);
        }

        public void Actualizar(CampanaDto campanaDto)
        {
            var campana = Mapper.Map<CampanaDto, Campana>(campanaDto);
            //repositorioCliente.Agregar(cliente);
            _contexto.CampanaRepository.Update(campana);
            _contexto.Commit();
        }

        public IList<CampanaDto> Buscar(string Busqueda)
        {
            var campanas = _contexto.CampanaRepository.GetAll(); //repositorioCliente.Traer();
            if (!string.IsNullOrEmpty(Busqueda)) campanas = campanas.Where(x => x.Nombre.Contains(Busqueda));

            return Mapper.Map<IList<Campana>, IList<CampanaDto>>(campanas.ToList());
        }
    }
}
