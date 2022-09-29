using System.ComponentModel.DataAnnotations;

namespace Peliculas.DTOs
{
    public class PeliculaInsertDTO
    {
        [Required(ErrorMessage = "El campo nombre es obligatorio.")]
        [StringLength(50, ErrorMessage = "El campo Nombre debe ser una cadena con una longitud máxima de 50.")] 
        public string Nombre { get; set; } = null!;
        [Required(ErrorMessage = "El campo Clasificacion es obligatorio.")]
        [StringLength(50, ErrorMessage = "El campo Clasificacion debe ser una cadena con una longitud máxima de 50.")]
        public string Clasificacion { get; set; } = null!;
        [Required(ErrorMessage = "El campo Fecha Estreno es obligatorio.")]
         public DateTime FechaEstreno { get; set; } = DateTime.Now;
        [Required(ErrorMessage = "El campo Protagonista es obligatorio.")]
        [StringLength(50, ErrorMessage = "El campo Protagonista debe ser una cadena con una longitud máxima de 50.")]
        public string Protagonista { get; set; } = null!;
        [Required(ErrorMessage = "El campo Director es obligatorio.")]
        [StringLength(50, ErrorMessage = "El campo Director debe ser una cadena con una longitud máxima de 50.")]
        public string Director { get; set; } = null!;
        [Required(ErrorMessage = "El campo Idioma es obligatorio.")]
        [StringLength(50, ErrorMessage = "El Idioma Ci debe ser una cadena con una longitud máxima de 50.")]
        public string Idioma { get; set; } = null!;
        [Required(ErrorMessage = "El campo Duracion es obligatorio.")]
        [StringLength(50, ErrorMessage = "El campo Duracion debe ser una cadena con una longitud máxima de 50.")]
        public string Duracion { get; set; } = null!;
        [Required(ErrorMessage = "El campo Sinopsis es obligatorio.")]
        [StringLength(50, ErrorMessage = "El campo Sinopsis debe ser una cadena con una longitud máxima de 50.")]
        public string? Sinopsis { get; set; }
        [Required(ErrorMessage = "El campo Categoria es obligatorio.")]
        public int IdCategoria { get; set; }
    }
    public class PeliculaActualizarDTO : PeliculaInsertDTO
    {
        [Required]
        public bool Estado { get; set; }


    }
}
