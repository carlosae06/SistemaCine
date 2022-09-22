using AutoMapper;
using BackEnd.DTOs.Categoria;
using BackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {

            //CreateMap<MateriaContenido, MateriaContenidoDTO>()
            //    .ForMember(x => x.EstadoNombre, x => x.MapFrom(y => y.IdEstadoNavigation != null ? y.IdEstadoNavigation.Nombre : ""))
            //    .ForMember(x => x.ModeloEstudioNombre, x => x.MapFrom(y => y.IdModeloEstudioNavigation != null ? y.IdModeloEstudioNavigation.Nombre : ""))
            //      .ForMember(x => x.GrupoAcademicoNombre, x => x.MapFrom(y => y.GrupoAcademico != null ? y.GrupoAcademico.Nombre : ""))
            //    .ReverseMap();


            CreateMap<CategoriaDTO, Categori>().ReverseMap();

            CreateMap<CategoriaInsertDTO, Categori>().ReverseMap();

        }
    }
}
