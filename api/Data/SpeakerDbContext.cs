using System;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class SpeakerDbContext : DbContext {
  public DbSet<Speaker> Speakers { get; set; }

  public SpeakerDbContext(DbContextOptions<SpeakerDbContext> options) : base(options) {

   }

  protected override void OnModelCreating(ModelBuilder builder) {
    base.OnModelCreating(builder);

    builder.Entity<Speaker>().HasData(
      new {
        SpeakerId = Guid.NewGuid().ToString(),
        FirstName = "Tom",
        LastName = "Day",
        Email = "aaa@aaa.com",
        MobileNumber="1231231234",
        Specialization="Java",
        City="Vancouver",
        Province="BC",
        Employer="Javazon Prime"
      }, new {
        SpeakerId = Guid.NewGuid().ToString(),
        FirstName = "John",
        LastName = "Ham",
        Email = "bbb@aaa.com",
        MobileNumber="1231231234",
        Specialization="Breakfast",
        City="Surrey",
        Province="BC",
        Employer="Denny's"
      }, new {
        SpeakerId = Guid.NewGuid().ToString(),
        FirstName = "Reneil",
        LastName = "Pascua",
        Email = "ccc@aaa.com",
        MobileNumber="1231231234",
        Specialization="Ultimate Frisbee",
        City="Richmond",
        Province="BC",
        Employer="AUDL"
      }
    );
  }
}

}