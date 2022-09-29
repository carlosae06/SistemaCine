using FrontEnd.DTOs.Persona;
using System.ComponentModel.DataAnnotations;

namespace FrontEnd.DTOs.Cliente
{
    public class ClienteInsertDTO
    {
        [Required(ErrorMessage = "El campo Nombre de Usuario es obligatorio.")]
        [StringLength(50, ErrorMessage = "El campo Nombre debe ser una cadena con una longitud máxima de 50.")]
        public string UserName { get; set; } = null!;
        [Required(ErrorMessage = "El campo Contraseña es obligatorio.")]
        [StringLength(400, ErrorMessage = "El campo Contraseña debe ser una cadena con una longitud máxima de 400.")]
        public string Password { get; set; } = null!;
        [Required(ErrorMessage = "El campo Email es obligatorio.")]
        [EmailAddress(ErrorMessage = "No tiene Formato de Correo Ej: ejemplo1@gmail.com")]
        [StringLength(200)]
        public string? Correo { get; set; }

        public bool Estado { get; set; }
        [Required(ErrorMessage = "El campo Persona es obligatorio.")]
         public int Idpersona { get; set; }
    }
    public class ClienteActualizarDTO : ClienteInsertDTO
    {
        [Required(ErrorMessage = "El campo nombre es obligatorio.")] 
        [StringLength(50)]
        public string UserName { get; set; } = null!;
    }
}
