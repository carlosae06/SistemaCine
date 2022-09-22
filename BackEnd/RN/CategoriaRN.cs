using AutoMapper;
using BackEnd.Data;
using BackEnd.DTOs;
using BackEnd.DTOs.Categoria;
using BackEnd.Helpers;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.RN
{
    public class CategoriaRN
    {
        private readonly CineContext context;
        private readonly IMapper mapper;

        public CategoriaRN(CineContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<ResponseListDTO<CategoriaDTO>> getAll(PaginacionDTO paginacion)
        {
            var query = context.Categoris.AsQueryable();

            var datosPaginacion = await query.datosPaginacion(paginacion.CantidadRegistrosPorPagina);
            var entidades = await query.Paginar(paginacion).ToListAsync();

            var list = mapper.Map<List<CategoriaDTO>>(entidades);

            return new ResponseListDTO<CategoriaDTO>
            {
                quanty = int.Parse(datosPaginacion["cantidadPaginas"]),
                page = paginacion.Pagina,
                total = int.Parse(datosPaginacion["totalRegistros"]),
                value = list
            };
        }

    }
}

