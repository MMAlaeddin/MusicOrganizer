using System;
using System.Collections.Generic;

namespace Organizer.Models
{
  public class Sound
  {
    public string Artist { get; set; }
    public string Song { get; set; }
    public string Genre { get; set; }
    private static List<Sound> _instances = new List<Sound> {};
    
    public Sounds(string artist, string song, string genre)
    {
      Artist = artist;
      Song = song;
      Genre = genre;
      _instances.Add(this); 
    }
    public static List<Sound> GetAll()
    {
      return _instances;
    }
  }
}