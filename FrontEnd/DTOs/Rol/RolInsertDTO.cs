using System.ComponentModel.DataAnnotations;

namespace FrontEnd.DTOs.Rol
{
    public class RolInsertDTO
    {
        [Required(ErrorMessage = "El campo nombre es obligatorio.")]
        [StringLength(10, ErrorMessage = "El DCOd Ci debe ser una cadena con una longitud máxima de 10.")]
        public string Cod { get; set; } = null!;
        [Required(ErrorMessage = "El campo nombre es obligatorio.")]
        [StringLength(50, ErrorMessage = "El campo Nombre debe ser una cadena con una longitud máxima de 50.")]
        public string Nombre { get; set; } = null!;

        public bool Estado { get; set; }
    }
    public class RolActualizarDTO : RolInsertDTO {

        public bool Estado { get; set; }
    }
}
