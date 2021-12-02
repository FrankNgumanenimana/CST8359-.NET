
using Lab4.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab4.Data
{
    public class SchoolCommunityContext : DbContext
    {
        public SchoolCommunityContext(DbContextOptions<SchoolCommunityContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Community> Communities { get; set; }
        public DbSet<Advertisement> Advertisements { get; set; }
        public DbSet<CommunityMembership> CommunityMemberships { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CommunityMembership>().HasKey(i => new { i.StudentId, i.CommunityId });
            modelBuilder.Entity<CommunityMembership>().HasOne(a => a.Student).WithMany(s => s.Membership).HasForeignKey(m => m.StudentId);
            modelBuilder.Entity<CommunityMembership>().HasOne(m => m.Community).WithMany(c => c.Membership).HasForeignKey(m => m.CommunityId);
            modelBuilder.Entity<Community>().HasMany(c => c.Advertisements).WithOne(ad => ad.Community);
            base.OnModelCreating(modelBuilder);
        }
    }
}