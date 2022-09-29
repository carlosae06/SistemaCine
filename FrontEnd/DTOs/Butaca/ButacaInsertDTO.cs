using FrontEnd.DTOs.Usuario;
using System.ComponentModel.DataAnnotations;

namespace FrontEnd.DTOs.Butaca
{
    public class ButacaInsertDTO
    {

        public bool? Estado { get; set; }
        [Required(ErrorMessage = "El campo Seccion es obligatorio.")]
         public int IdSeccion { get; set; }
    }
    public class ButacaActualizarDTO : ButacaInsertDTO
    {
        public bool Estado { get; set; }
    }
}