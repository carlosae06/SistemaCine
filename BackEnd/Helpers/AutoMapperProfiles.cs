using AutoMapper;
using BackEnd.DTOs.Categoria;
using BackEnd.DTOs.Cliente;
using BackEnd.DTOs.Pelicula;
using BackEnd.DTOs.Persona;
using BackEnd.DTOs.Usuario;
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

            CreateMap<PeliculaDTO, Pelicula>().ReverseMap();

            CreateMap<PeliculaInsertDTO, Pelicula>().ReverseMap();

            CreateMap<PeliculaUpdateDTO, Pelicula>().ReverseMap();

            CreateMap<CategoriaUpdateDTO, Categori>().ReverseMap();

            CreateMap<CategoriaDTO, Categori>().ReverseMap();

            CreateMap<CategoriaInsertDTO, Categori>().ReverseMap();

            CreateMap<PersonaDTO, Persona>().ReverseMap();

            CreateMap<PersonaInsertDTO, Persona>().ReverseMap();

            CreateMap<PersonaUpdateDTO, Persona>().ReverseMap();

            CreateMap<ClienteDTO, Cliente>().ReverseMap();

            CreateMap<ClienteInsertDTO, Cliente>().ReverseMap();

            CreateMap<ClienteUpdateDTO, Cliente>().ReverseMap();

            CreateMap<UsuarioDTO, Usuario>().ReverseMap();

            CreateMap<UsuarioInsertDTO, Usuario>().ReverseMap();

            CreateMap<UsuarioUpdateDTO, Usuario>().ReverseMap();



        }
    }
}
