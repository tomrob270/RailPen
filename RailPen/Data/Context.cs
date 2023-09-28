using Microsoft.EntityFrameworkCore;
using RailPen.Models;
using System.Globalization;
using static RailPen.Models.Member;

namespace RailPen.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
        public DbSet<Member> Members { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var cultureInfo = new CultureInfo("en-GB");

            modelBuilder.Entity<Member>().HasData(
                new Member { Id = 1, FirstName = "Brian", LastName = "Mccall", PensionReferenceNumber = "P0000097", DateOfBirth = DateTime.Parse("01/08/1965", cultureInfo), Gender = GenderEnum.Male, TargetRetirementAge = 60 },
                new Member { Id = 2, FirstName = "Sarah", LastName = "Kramer", PensionReferenceNumber = "PO000136", DateOfBirth = DateTime.Parse("03/04/1984", cultureInfo), Gender = GenderEnum.Female, TargetRetirementAge = 60 },
                new Member { Id = 3, FirstName = "Lianne", LastName = "Barrow", PensionReferenceNumber = "P0004657", DateOfBirth = DateTime.Parse("26/09/1975", cultureInfo), Gender = GenderEnum.Female, TargetRetirementAge = 62 },
                new Member { Id = 4, FirstName = "David", LastName = "Richardson", PensionReferenceNumber = "P0004701", DateOfBirth = DateTime.Parse("25/12/1980", cultureInfo), Gender = GenderEnum.Male, TargetRetirementAge = 65 },
                new Member { Id = 5, FirstName = "Kara", LastName = "Mccall", PensionReferenceNumber = "P0004782", DateOfBirth = DateTime.Parse("06/05/1992", cultureInfo), Gender = GenderEnum.Female, TargetRetirementAge = 65 }
            );
        }
    }
}
