using Lab3.Classes;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace Lab3.DataBase
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Typeofwork> Typeofworks { get; set; }
        public DbSet<Workcatalog> Workcatalog { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
