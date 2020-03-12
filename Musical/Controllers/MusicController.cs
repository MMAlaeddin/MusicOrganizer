using Microsoft.AspNetCore.Mvc;
using Organizer.Models;
using System.Collections.Generic;

namespace Organizer.Controllers
{
  public class MusicController : Controller
  {
    [HttpPost("/artists")]
      public ActionResult Create(string artist, string song, string genre)
      {
        Sound newSound = new Sound(artist, song, genre);
        return RedirectToAction("Index", newSound);
      }
      [HttpGet("/artists/new")]
      public ActionResult New()
      {
        return View();
      }
  }
}