using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Models
{
    public class ListItems
    {
        public List<SelectListItem> obtenerListado()
        {
            return new List<SelectListItem>()
            {
                new SelectListItem()
                {
                    Text = "Si",
                    Value = "1"
                },
                new SelectListItem()
                {
                    Text = "No",
                    Value = "2"
                },
                new SelectListItem()
                {
                    Text = "Tal vez",
                    Value = "3"
                }
            };
        }
    }
    
}