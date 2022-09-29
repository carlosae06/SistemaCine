using FrontEnd.DTOs.Usuario;
using System.ComponentModel.DataAnnotations;

namespace FrontEnd.DTOs.Venta
{
    public class VentaInsertDTO
    {
        [Required(ErrorMessage = "El campo Fecha es obligatorio.")]
        public DateTime Fecha { get; set; }
        [Required(ErrorMessage = "El campo Precio Total es obligatorio.")]
        public decimal PrecioTotal { get; set; }
        [Required(ErrorMessage = "El campo Documento es obligatorio.")]
        [StringLength(10, ErrorMessage = "El campo Documento debe ser una cadena con una longitud máxima de 10.")]
        public string? Documento { get; set; }
        [Required(ErrorMessage = "El campo Documento es obligatorio.")]
        [StringLength(50, ErrorMessage = "El campo Documento debe ser una cadena con una longitud máxima de 50.")]
        public string? NumDocumento { get; set; }
        [Required(ErrorMessage = "El campo Complemento es obligatorio.")]
        [StringLength(10, ErrorMessage = "El campo Ci debe ser una cadena con una longitud máxima de 10.")]
        public string? Complemento { get; set; }
        [Required(ErrorMessage = "El campo Telefono es obligatorio.")]
        [StringLength(50, ErrorMessage = "El campo Telefono debe ser una cadena con una longitud máxima de 50.")]
        public string Telefono { get; set; } = null!;
    }
    public class VentaActualizarDTO : VentaInsertDTO
    {
        [Required]
        public DateTime Fecha { get; set; }
    }
}
