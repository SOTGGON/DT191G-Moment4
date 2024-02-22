using System.ComponentModel.DataAnnotations;

namespace SongList.Models;

//Uppgift 1
public class Song {
    public int Id {get; set;}

    [Required]
    public string? Title {get; set;}

    [Required]
    public int? Length {get; set;}

    [Required]
    public string? Category {get; set;}

    // Foreign Key
    public int ArtistId { get; set; }

    // Navigation Property
    public Artist Artist { get; set; }
}