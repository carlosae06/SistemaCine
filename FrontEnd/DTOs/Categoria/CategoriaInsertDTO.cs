using System.ComponentModel.DataAnnotations;

namespace FrontEnd.DTOs.Categoria
{
    public class CategoriaInsertDTO
    {
        [Required(ErrorMessage = "El campo NOMBRE es obligatorio.")]
        [StringLength(50, ErrorMessage = "El campo Nombre debe ser una cadena con una longitud máxima de 50.")]
        public string? Nombre { get; set; }

        public bool Estado { get; set; }
    }

    public class CategoriaActualizarDTO : CategoriaInsertDTO {
       
        [Required]
        public bool Estado { get; set; }
    }
}
