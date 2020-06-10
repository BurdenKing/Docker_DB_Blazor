using System;
using Microsoft.EntityFrameworkCore;

namespace SpeakerApi {
    public class ApplicationDbContext : DbContext {
        public DbSet<Speaker> Speakers { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder) {
            base.OnModelCreating(builder);
            builder.Entity<Speaker>().HasData(
                new Speaker{
                    SpeakerId = Guid.NewGuid().ToString(),
                    FirstName = "Choi",
                    LastName = "Yena",
                    Email = "c@c.c",
                    Phone = "6045555555",
                    AreaSpecification = "Idol",
                    City = "Seoul",
                    Province = "Gyeonggi",
                    Employer = "Off The Record"
                }
            );
        }
    }
}
