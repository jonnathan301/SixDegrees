using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Usuario
    {
        [Key]
        public decimal UsuId { get; set; }
        [MaxLength(100)]
        public string Nombre { get; set; }
        [MaxLength(100)]
        public string Apellido { get; set; }
    }
}