using Cre8.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cre8.Web.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            Site dummySite = new Site();

            dummySite.Title = "Cre8 - Startpage";
            

            dummySite.Gears.Add(new Text() {  HtmlContent="<h1>Sup brah</h1>"});

            dummySite.Gears.Add(new Picture() { Source = "/Data/dog.jpg", AltText = "Doggo" });


            return View(dummySite);
        }
       

    }
}