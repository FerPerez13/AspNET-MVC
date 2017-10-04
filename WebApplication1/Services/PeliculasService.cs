using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class PeliculasService
    {
        public Pelicula ObtenerPelicula()
        {
            return new Pelicula()
            {
                Titulo = "Harry Potter",
                Duracion = 115,
                Pais = "USA",
                Publicacion = new DateTime(2013, 12, 5)
            };

        }

        public List<Pelicula> ObtenerPeliculas()
        {
            // TODO ESTO LO TENDRÍA QUE RECOGER DESDE UNA BASE DE DATOS
            var pelicula1 = new Pelicula()
            {
                Titulo = "Harry Potter y la piedra filosofal",
                Duracion = 115,
                Pais = "USA",
                Publicacion = new DateTime(2013, 12, 5)
            };

            var pelicula2 = new Pelicula()
            {
                Titulo = "Batman, el caballero oscuro",
                Duracion = 213,
                Pais = "UK",
                Publicacion = new DateTime(2014, 11, 5)
            };
            // -----------------------------------------------------------

            return new List<Pelicula> { pelicula1, pelicula2 }; // Devolvemos la lista de las peliculas
        }
    }
}