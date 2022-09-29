using System.ComponentModel.DataAnnotations;

namespace FrontEnd.DTOs.Control
{
    public class ControlInsertDTO
    {
        [Required(ErrorMessage = "El campo Ticket es obligatorio.")]
        public int IdTicket { get; set; }

        public bool Estado { get; set; }
    }
    public class ControlActualizarDTO : ControlInsertDTO
    {
        public bool Estado { get; set; }
    }
}
