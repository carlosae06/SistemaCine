namespace BackEnd.DTOs.Pelicula
{
    public class PeliculaDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Clasificacion { get; set; } = null!;
        public DateTime FechaEstreno { get; set; }
        public string Protagonista { get; set; } = null!;
        public string Director { get; set; } = null!;
        public string Idioma { get; set; } = null!;
        public string Duracion { get; set; } = null!;
        public string? Sinopsis { get; set; }
        public bool? Estado { get; set; }
        public int IdCategoria { get; set; }
    }
}
