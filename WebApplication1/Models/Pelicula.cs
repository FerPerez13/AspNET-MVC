using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Pelicula
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int Duracion { get; set; }
        public DateTime Publicacion { get; set; }
        public string Pais { get; set; }
        public bool Visto { get; set; }
    }
}