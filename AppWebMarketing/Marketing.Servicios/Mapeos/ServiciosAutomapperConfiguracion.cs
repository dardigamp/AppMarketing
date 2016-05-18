using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Marketing.Servicios.Campanas.Dtos;
using Marketing.Repositorios.Dominio;
using Marketing.Servicios.Clientes.Dtos;

namespace Marketing.Servicios.Mapeos
{
    public class ServiciosAutomapperConfiguracion
    {
        public static void Configuracion()
        {            
            Mapper.CreateMap<Campana, CampanaDto>();
            Mapper.CreateMap<CampanaDto, Campana>();
            Mapper.CreateMap<Cliente, ClienteDto>();
        }
    }
}
