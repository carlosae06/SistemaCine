using BackEnd.DTOs;
using BackEnd.DTOs.Categoria;
using BackEnd.RN;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private readonly CategoriaRN categoriaRN;

        public CategoriasController(CategoriaRN categoriaRN)
        {
            this.categoriaRN = categoriaRN;

        }

        [HttpGet]
        [ProducesResponseType(typeof(ResponseListDTO<CategoriaDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseError), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Get([FromQuery] PaginacionDTO paginacion)
        {
            try
            {
                var datos = await categoriaRN.getAll(paginacion);
                return Ok(datos);

            }
            catch (Exception ex)
            {
                return new ResponseError(StatusCodes.Status400BadRequest, ex.Message).GetObjectResult();
            }
        }
    }
}
