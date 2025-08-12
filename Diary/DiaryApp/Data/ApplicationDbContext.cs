using DiaryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DiaryApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        public DbSet<DiaryEntry> DiaryEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // GOOD seeding (deterministic)
            modelBuilder.Entity<DiaryEntry>().HasData(
                new DiaryEntry { Id = 1, Title = "went hiking", Content = "went hiking with joe", Created = new DateTime(2025, 08, 10, 14, 07, 53, DateTimeKind.Utc) },
                new DiaryEntry { Id = 2, Title = "went shopping", Content = "went shopping with joe", Created = new DateTime(2025, 08, 10, 14, 07, 53, DateTimeKind.Utc) }
            );

        }
    }
}
