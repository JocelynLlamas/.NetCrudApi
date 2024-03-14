using Microsoft.EntityFrameworkCore;
using SuperHeroAPI_DotNet8.Entities;

namespace SuperHeroAPI_DotNet8.Data
{
    public class DataContext : DbContext
    {
        //Para poner el constructor poner ctro
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        //Para poner el constructor poner prop
        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
}
