using Microsoft.AspNetCore.Mvc;

namespace Assigment_Portafolio_II.controller;

public class HomeController : Controller
{
    [HttpGet]
    [Route("")]
    public ViewResult Index()
    {
        return View("Index");
    }

    [HttpGet]
    [Route("/projects")]
    public ViewResult Projects()
    {
        List<string> projectslist = new List<string>()
        {
            "Tren Ciudad",
            "Hexagon PetStore",
            "CSW",
            "MDA"
        };
        ViewBag.projects = projectslist;
        return View("Projects");
    }

    [HttpGet]
    [Route("/contact")]
    public ViewResult Contacto()
    {
        return View("Contacto");
    }
}
