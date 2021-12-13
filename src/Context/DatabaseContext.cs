using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using ImdbMovies.ActorModel;

namespace ImdbMovies.Context 
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options){}

        public DbSet<Actor> Actors {get; set;} = null;
    }
}