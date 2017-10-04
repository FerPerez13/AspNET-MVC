using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.DAL
{
    public class PeliculasRepository
    {
        public List<Pelicula> ObtenerPeliculas()
        {
            return new List<Pelicula>()
            {
                new Pelicula()
                {
                    Titulo = "Juegos del Hambre",
                    Duracion = 201,
                    Pais = "EEUU",
                    Publicacion = new DateTime(2015, 1, 23),
                    Visto = true
                },
                new Pelicula()
                {
                    Titulo = "Batman vs Superman",
                    Duracion = 220,
                    Pais = "EEUU",
                    Publicacion = new DateTime(2016, 4, 30),
                    Visto = true
                },
                new Pelicula()
                {
                    Titulo = "Los vengadores",
                    Duracion = 180,
                    Pais = "EEUU",
                    Publicacion = new DateTime(2013, 6, 12),
                },
                new Pelicula()
                {
                    Titulo = "DeadPool",
                    Duracion = 200,
                    Pais = "EEUU",
                    Publicacion = new DateTime(2014, 12, 3),
                    Visto = true,
                },
                new Pelicula()
                {
                    Titulo = "Harry Potter y la piedra filosofal",
                    Duracion = 115,
                    Pais = "USA",
                    Publicacion = new DateTime(2011, 11, 23),
                },
                new Pelicula()
                {
                    Titulo = "Batman, el caballero oscuro",
                    Duracion = 213,
                    Pais = "UK",
                    Publicacion = new DateTime(2008, 3, 12),
                    Visto = true,
                }
            };
        }
    }
}