using FrontEnd.DTOs.Usuario;
using System.ComponentModel.DataAnnotations;

namespace FrontEnd.DTOs.Ticket
{
    public class TicketInsertDTO
    {
        [Required(ErrorMessage = "El campo Cod es obligatorio.")]
        [StringLength(50, ErrorMessage = "El campo Cod debe ser una cadena con una longitud máxima de 50.")]
        public string Cod { get; set; } = null!;
        [Required(ErrorMessage = "El campo Precio es obligatorio.")]
        public decimal Precio { get; set; }
        [Required(ErrorMessage = "El Tipo de Pago es obligatorio.")]
        [StringLength(50, ErrorMessage = "El campo Tipo de Pago debe ser una cadena con una longitud máxima de 50.")]
        public string TipoPago { get; set; } = null!;
        [Required(ErrorMessage = "El campo Butacaes obligatorio.")]
        public int IdButaca { get; set; }
        [Required(ErrorMessage = "El campo Cliente es obligatorio.")]
        public int IdCliente { get; set; }
        [Required(ErrorMessage = "El campo Funcion es obligatorio.")]
        public int IdFunsion { get; set; }
        [Required(ErrorMessage = "El campo Venta es obligatorio.")]
        public int IdVenta { get; set; }
        [Required(ErrorMessage = "El campo Usuario es obligatorio.")]
        public int? IdUsuario { get; set; }
    }
    public class TicketActualizarDTO : TicketInsertDTO
    {
        [Required]
        public decimal Precio { get; set; }
    }
}
