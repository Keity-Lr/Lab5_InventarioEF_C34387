using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace Lab5_InventarioEF_C34387.Models
{
    public class Producto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        [Range(1, 9999999)]
        public decimal Precio { get; set; }

        [Required]
        public string Categoria { get; set; }

        public bool Activo { get; set; }

        public DateTime FechaIngreso { get; set; } = DateTime.Now;

    }
}
