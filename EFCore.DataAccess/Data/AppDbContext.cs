using Microsoft.EntityFrameworkCore;

using EFCore.Models;
using EFCore.Models.Models;

namespace EFCore.DataAccess.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> Options) : base(Options)
        {

        }
        public DbSet<MelissaModel> MmModel { get; set; }
        public DbSet<OurModel> OurMM { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<MelissaModel>().HasData(
            new MelissaModel { Id = 1, Name = "Melisa", Age = 33, College = "Completed" },
            new MelissaModel { Id = 2, Name = "Melisa", Age = 34, College = "Compleft00ed" }
        );


            modelBuilder.Entity<OurModel>().HasData(
                new OurModel { Id = "1", Title = "Title1", AuthorName = "Author1" },
                new OurModel { Id = "2", Title = "Title2", AuthorName = "Author2" }
                );


        }
    }
}
