
using System.ComponentModel.DataAnnotations;

namespace ExamenAPI.DTOs
{
    public class ActualizarProductoDto
    {
        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [MaxLength(255)]
        public string? Descripcion { get; set; }

        [Range(0, 99999999)]
        public decimal Precio { get; set; }

        [Range(0, int.MaxValue)]
        public int Stock { get; set; }
    }
}
