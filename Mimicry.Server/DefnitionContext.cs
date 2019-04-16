using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Mimicry.Server
{
    public sealed class DefinitionContext : DbContext
    {
        public DefinitionContext(string fileName = null)
        {
            FileName = fileName ?? "mimicry.db";
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=" + FileName, options =>
            {
                options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
            });


            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<MimicDefinitionDTO> MimicDefinitions { get; set; }
        public string FileName { get; }
    }
}
