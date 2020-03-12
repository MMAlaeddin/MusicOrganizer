using Microsoft.AspNetCore.Mvc;
using Organzier.Models;
using System.Collections.Generic;

namespace Organzier.Controllers
{
  public class MusicController : Controller
  {
    [HttpPost("/artists")]
    {
      public ActionResult Create(string artist, string song, string genre)
      {
        Sound newSound = new Sound(artist, song, genre);
        return RedirectToAction("Index", newSound);
      }
    }
  }
}