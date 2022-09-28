using System.ComponentModel.DataAnnotations;

namespace FrontEnd.DTOs.Sala
{
    public class SalaInsertDTO
    {
        [Required(ErrorMessage = "El campo nombre es obligatorio.")]
        [StringLength(10)]
        public string Cod { get; set; } = null!;
        [Required(ErrorMessage = "El campo nombre es obligatorio.")]
        public int Fila { get; set; }
        [Required(ErrorMessage = "El campo nombre es obligatorio.")]
        public int Columna { get; set; }
        [Required(ErrorMessage = "El campo nombre es obligatorio.")]
        public int Capacidad { get; set; }

        public bool Estado { get; set; }
    }
    public class SalaActualizarDTO : SalaInsertDTO {

        public bool Estado { get; set; }
    }
}
