using SongList.Models;
using Microsoft.EntityFrameworkCore;

namespace SongList.Data;

public class SongContext : DbContext {
    public SongContext(DbContextOptions<SongContext> options) : base(options) {

    }

    public DbSet<Song> Songs {get; set;} = null;
}