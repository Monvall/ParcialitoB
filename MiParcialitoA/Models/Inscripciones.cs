﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiParcialitoA.Models
{
    public class Inscripciones
    {
        [Key]
        public int IdInscripciones { get; set; }

        [ForeignKey(nameof(Estudiante))]
        public int EstudianteID { get; set; }

        public virtual Estudiantes? Estudiante { get; set; }


        [ForeignKey(nameof(Curso))]
        public int CursoID { get; set; }

        public virtual Cursos? Curso { get; set; }
    }
}
