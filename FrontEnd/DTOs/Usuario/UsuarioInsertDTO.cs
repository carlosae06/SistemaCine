using System.ComponentModel.DataAnnotations;

namespace FrontEnd.DTOs.Usuario
{
    public class UsuarioInsertDTO
    {
        [Required(ErrorMessage = "El campo Nombre de Usuario es obligatorio.")]
        [StringLength(50, ErrorMessage = "El campo Nombre de Usuario debe ser una cadena con una longitud máxima de 50.")]
        public string UserName { get; set; } = null!;
        [Required(ErrorMessage = "El campo Contraseña es obligatorio.")]
        [StringLength(400, ErrorMessage = "El campo Contraseña debe ser una cadena con una longitud máxima de 400.")]
        public string Password { get; set; } = null!;
        [Required(ErrorMessage = "El campo Nombre de Correo es obligatorio.")]
        [EmailAddress (ErrorMessage = "No tiene Formato de Correo Ej: ejemplo1@hotmail.com")]
        [StringLength(200)]
        public string Correo { get; set; }

        public bool Estado { get; set; }
        [Required(ErrorMessage = "El campo Persona de Usuario es obligatorio.")]
        public int Idpersona { get; set; }
        [Required(ErrorMessage = "El campo Rol de Usuario es obligatorio.")]
        public int IdRol { get; set; }
    }
    public class UsuarioActualizarDTO : UsuarioInsertDTO
    {
        public bool Estado { get; set; }
    }
}
