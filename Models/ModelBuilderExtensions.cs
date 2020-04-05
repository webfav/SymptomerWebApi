using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SymptomerWebApi.Models
{
    public static class ModelBuilderExtensions
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Regioner>().HasData(
            new Regioner { Id = 1, Name = "Region Hovedstaden" },
            new Regioner { Id = 2, Name = "Region Sjælland" },
            new Regioner { Id = 3, Name = "Region Syddanmark" },
            new Regioner { Id = 4, Name = "Region Midtjylland" },
            new Regioner { Id = 5, Name = "Region Nordjylland" });

            modelBuilder.Entity<Symptomer>().HasData(
                new Symptomer { Id = 1, Date = DateTime.Parse("2020-03-24"), Alder = "40", Køn = "Mand", RegionId = 1, Nyser = true, Hoster = true, Feber = true, Muskelømhed = true, Diarre = true, Opkast = false, Hovedpine = true, Halsonde = true, Stakåndethed = true, Udmattet = true, Sansetab = false, Andet ="Mavesmerter" },
                new Symptomer { Id = 2, Date = DateTime.Parse("2020-03-25"), Alder = "45", Køn = "Kvinde", RegionId = 2, Nyser = true, Hoster = true, Feber = true, Muskelømhed = true, Diarre = true, Opkast = false, Hovedpine = true, Halsonde = true, Stakåndethed = true, Udmattet = true, Sansetab = false, Andet = "Svimmel" },
                new Symptomer { Id = 3, Date = DateTime.Parse("2020-03-26"), Alder = "50", Køn = "Mand", RegionId = 3, Nyser = true, Hoster = false, Feber = true, Muskelømhed = true, Diarre = false, Opkast = false, Hovedpine = true, Halsonde = true, Stakåndethed = true, Udmattet = false, Sansetab = false, Andet = "Ondt i ører" },
                new Symptomer { Id = 4, Date = DateTime.Parse("2020-03-27"), Alder = "30", Køn = "Kvinde", RegionId = 4, Nyser = true, Hoster = true, Feber = true, Muskelømhed = true, Diarre = true, Opkast = true, Hovedpine = false, Halsonde = false, Stakåndethed = true, Udmattet = false, Sansetab = true, Andet = "Næseblod" },
                new Symptomer { Id = 5, Date = DateTime.Parse("2020-03-28"), Alder = "55", Køn = "Mand", RegionId = 5, Nyser = true, Hoster = true, Feber = false, Muskelømhed = false, Diarre = false, Opkast = false, Hovedpine = true, Halsonde = true, Stakåndethed = true, Udmattet = true, Sansetab = false, Andet = "Mavesmerter" },
                new Symptomer { Id = 6, Date = DateTime.Parse("2020-03-29"), Alder = "59", Køn = "Mand", RegionId = 1, Nyser = false, Hoster = true, Feber = true, Muskelømhed = true, Diarre = true, Opkast = false, Hovedpine = true, Halsonde = true, Stakåndethed = true, Udmattet = true, Sansetab = false, Andet = "" },
                new Symptomer { Id = 7, Date = DateTime.Parse("2020-03-30"), Alder = "65", Køn = "Kvinde", RegionId = 2, Nyser = true, Hoster = true, Feber = true, Muskelømhed = false, Diarre = true, Opkast = false, Hovedpine = true, Halsonde = true, Stakåndethed = true, Udmattet = true, Sansetab = false, Andet = "Svimmel" },
                new Symptomer { Id = 8, Date = DateTime.Parse("2020-03-31"), Alder = "70", Køn = "Mand", RegionId = 3, Nyser = true, Hoster = false, Feber = true, Muskelømhed = true, Diarre = false, Opkast = false, Hovedpine = true, Halsonde = true, Stakåndethed = true, Udmattet = false, Sansetab = false, Andet = "Ondt i ører" },
                new Symptomer { Id = 9, Date = DateTime.Parse("2020-04-01"), Alder = "43", Køn = "Kvinde", RegionId = 4, Nyser = false, Hoster = true, Feber = false, Muskelømhed = true, Diarre = true, Opkast = true, Hovedpine = false, Halsonde = false, Stakåndethed = true, Udmattet = false, Sansetab = true, Andet = "" },
                new Symptomer { Id = 10, Date = DateTime.Parse("2020-04-02"), Alder = "70", Køn = "Mand", RegionId = 5, Nyser = true, Hoster = true, Feber = true, Muskelømhed = false, Diarre = false, Opkast = false, Hovedpine = true, Halsonde = true, Stakåndethed = true, Udmattet = true, Sansetab = false, Andet = "" }
                );

        }
    }
}
