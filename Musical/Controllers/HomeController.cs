using Microsoft.AspNetCore.Mvc;
using Organizer.Models;

namespace Organizer.Controllers

{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}
