
using System.ComponentModel.DataAnnotations;

namespace LaZonaAdmin.Blazor2.Models
{
    public class Rol
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es requerido")]
        public string Nombre { get; set; }


    }
}
