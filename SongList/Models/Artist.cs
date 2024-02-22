using System.ComponentModel.DataAnnotations;

namespace SongList.Models;

//Uppgift 1
public class Artist {
    public int Id {get; set;}

    [Required]
    public string? Name {get; set;}

    [Required]
    public string? Country {get; set;}

    [Required]
    public DateTime DateOfBirth { get; set; }

    [Required]
    public string? Genre {get; set;}

    // Navigation Property
    public virtual ICollection<Song> Songs { get; set; }
}