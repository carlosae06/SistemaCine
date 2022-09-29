using System.ComponentModel.DataAnnotations;

namespace FrontEnd.DTOs.Funsion
{
    public class FunsionInsertDTO
    {
        [Required(ErrorMessage = "El campo Fecha es obligatorio.")]
        public DateTime Fecha { get; set; }
        [Required(ErrorMessage = "El campo Horario es obligatorio.")]
        [StringLength(30)]
        public string Horario { get; set; } = null!;
        [Required(ErrorMessage = "El campo Sala es obligatorio.")]
        public int IdSala { get; set; }
        [Required(ErrorMessage = "El campo Pelicula es obligatorio.")]
        public int IdPelicula { get; set; }
    }
    public class FunsionActualizarDTO : FunsionInsertDTO
    {
        [Required]
        public DateTime Fecha { get; set; }
    }
}
