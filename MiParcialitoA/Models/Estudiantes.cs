using System.ComponentModel.DataAnnotations;

namespace MiParcialitoA.Models
{
    public class Estudiantes
    {
        [Key]
        public int EstudiantesId { get; set; }

        public string Nombre { get; set; }
    }
}
