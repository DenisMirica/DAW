using System.ComponentModel.DataAnnotations;

namespace DAW.Models
{
    public class Participanti
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nume { get; set; }

        [Required]
        public string Rol { get; set; }

      
    }
}
