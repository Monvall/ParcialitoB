using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MiParcialitoA.Models
{
    public class Cursos
    {
        [Key]
        public int CursosId { get; set; }

        public string NombreCurso { get; set; }
    }

}