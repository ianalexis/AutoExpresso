﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace mvc.Models
{
    public class Estudiante
    {
        [Key]//entre corchetes, anotaciones
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        [Display(Name = "Fecha inscripción")]
        public DateTime FechaInscripto { get; set; }
        [EnumDataType(typeof(Deporte))]
        public Deporte DeporteFavorito { get; set; }
    }

   


}
