using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.DAL;
using WebApplication1.Models;
using WebApplication1.DAL;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private PeliculasRepository _peliculasRepository;

        public HomeController()
        {
            _peliculasRepository = new PeliculasRepository();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            var peliculaService = new PeliculasRepository();
            var model = peliculaService.ObtenerPeliculas();

            return View(model);
        }

        // #### DIFERENTES FORMAS DE PASAR CONTENIDO A LAS PANTALLAS ####
        // (Arriba tenemos la típica, un ActionResult enviando un View() vacío o lleno)

        /* Pasar Contenido plano 
        public ContentResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return Content("Fernando"); // También podemos poner HTML breve
        }        
        */

        /* Enviar un JSON a la siguiente pantalla
        public JsonResult Contact()
        {
            var pelicula = new Pelicula() {Titulo = "Batman Begins", Duracion = 180, Pais = "Estados Unidos" };
            var pelicula2 = new Pelicula() { Titulo = "The Amazing Spiderman", Duracion = 150, Pais = "EE.UU" };
            var pelicula3 = new Pelicula() { Titulo = "Wonder Woman", Duracion = 192, Pais = "Estados Unidos" };
            var pelicula4 = new Pelicula() { Titulo = "Injustice", Duracion = 200, Pais = "Canada" };


            return Json(new List<Pelicula>() { pelicula, pelicula2, pelicula3, pelicula4 }, JsonRequestBehavior.AllowGet); //Cuidado que tenemos que poner JsonRequestBehavior.AllowGet para que nos deje por Get 
        }
        */

        /* Hacer una Redirección cuando pulsemos
        public RedirectToRouteResult Contact()
        {
            //return Redirect("https://www.stackoverflow.com"); // (RedirectResult) Enviar a otra página fuera de nuestro sitio web
            return RedirectToAction("Register", "Account"); // (RedirectToRouteResult) Hay que cambiar RedirectResult por RedirectToRouteResult
        } 
        */

        /* Descargar un archivo desde la web
        public FileResult Contact()
        {
            var ruta = Server.MapPath("/Sources/ejemplo.pdf"); // La ruta se puede poner con "/" o con "//"
            return File(ruta, "application/pdf","ejemplo.pdf");
        }
        */

        /* Parametros en un action y QueryString 
        public ActionResult Contact(string nombre)
        {
            ViewBag.Message = "Your Contact Page." + nombre; // Lo tendremos que poner en la URL del navegador ?{Variable}={valor}
            return View(); // No es recomendable para datos sensibles
        }        
        */

        /* httpGet y httpPost 
        [HttpGet] // Solo arrancará este trozo cuando hagamos un GET (Peticion de recibir info de web)
        public ActionResult Contact()
        {
            ViewBag.Message = "Your Contact Page.";
            return View(); 
        }

        [HttpPost] // Solo arrancará este trozo cuando hagamos un POST (Envio de información a página)
        public ActionResult Contact(int edad)
        {
            ViewBag.Message = "Your Contact Page. Your age is " + edad; 
            return View(); 
        }
        */

        /* ViewBag y ViewData */
        public ActionResult Contact()
        { //Los valores no se guardan en el servidor. Solo estarán disponibles para la vista que invocamos
            ViewBag.Message = "Enviado con ViewBag";
            ViewData["Mensaje"] = "Enviado con ViewData";
            return View();
        }
        //*/

        // ########## A continuación se hará todo lo referente a las Vistas ##########
        public ActionResult MiAction()
        {
            ViewBag.Message = "Peliculas que tenemos en la BBDD";
            var model = _peliculasRepository.ObtenerPeliculas();
            
            ViewBag.Objeto = model[2]; // Le pasamos a @Html.Display() el objeto con el ViewBag

            ListItems listItems = new ListItems();
            ViewBag.Listado = listItems.obtenerListado();

            ViewBag.ListaPelis = model; // Le pasamos a _ListaPeliculas el listado de películas

            return View(model);
        }

    }
}