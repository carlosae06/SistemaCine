using System.ComponentModel.DataAnnotations;
using System.Runtime.ConstrainedExecution;

namespace FrontEnd.DTOs.Persona
{
    public class PersonaInsertDTO
    {
        [Required(ErrorMessage = "El campo CI es obligatorio.")]
        [StringLength(20, ErrorMessage = "El campo Ci debe ser una cadena con una longitud máxima de 20.")]
        public string Ci { get; set; } = null!;
        [Required(ErrorMessage = "El campo NOMBRE es obligatorio.")]
        [StringLength(50, ErrorMessage = "El campo Nombre debe ser una cadena con una longitud máxima de 50.")]
        public string Nombre { get; set; } = null!;
        [Required(ErrorMessage = "El campo Apellido Paterno es obligatorio.")]
        [StringLength(20, ErrorMessage = "El campo Apellido Paterno debe ser una cadena con una longitud máxima de 20.")]
        public string ApellidoPaterno { get; set; } = null!;
        [Required(ErrorMessage = "El campo Apellido Materno es obligatorio.")]
        [StringLength(20, ErrorMessage = "El campo Apellido Materno debe ser una cadena con una longitud máxima de 20.")]
        public string ApellidoMaterno { get; set; } = null!;
        [Required(ErrorMessage = "El campo Telefono es obligatorio.")]
        [StringLength(10, ErrorMessage = "El campo Telefono debe ser una cadena con una longitud máxima de 10.")]
        public string? Telefono { get; set; }
    }
    public class PersonaActualizarDTO : PersonaInsertDTO{

        [Required(ErrorMessage = "El campo nombre es obligatorio.")]
        [StringLength(50)]
        public string Nombre { get; set; } = null!;
    }
}
