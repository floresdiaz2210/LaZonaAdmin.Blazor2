using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LaZonaAdmin.Blazor2.Models
{
    public class Categorias
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "La categoria es obligatorio")]
        public string Categoria { get; set; }

    }
}
