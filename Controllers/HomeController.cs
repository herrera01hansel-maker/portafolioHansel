using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PortafolioHansel.Models;

namespace PortafolioHansel.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View(DatosPortafolio.Obtener());
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
