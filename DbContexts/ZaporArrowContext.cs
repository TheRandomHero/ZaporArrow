using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ZaporArrow.Entities;
using ZaporArrow.Models;

namespace ZaporArrow.DbContexts
{
    public class ZaporArrowContext : DbContext
    {
        public ZaporArrowContext(DbContextOptions<ZaporArrowContext> options)
            : base(options)
        {
        }

        public DbSet<Arrow> Arrows { get; set; }

        public DbSet<Image> Images { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Arrow>().HasData(
                new Arrow
                {
                    ArrowId = Guid.Parse("97bcd962-2a0d-4489-8e48-19dd2c848893"),
                    Length = 30,
                    Description = "extra donga 7mm, 22 - 22, 2gramm 30 font!"

                },
                new Arrow
                {
                    ArrowId = Guid.Parse("e71847d9-1ddb-4db1-8af5-801803d6151c"),
                    Length = 29.5,
                    Description = "35 font, 23g 0,3tized gramm szórásban. 8 ról 7es extra donga!"

                },
                 new Arrow
                 {
                     ArrowId = Guid.Parse("019e54c4-5a54-42d3-a78a-8b3d9dd0d85d"),
                     Length = 30,
                     Description = "35#, 22,2-22,5g Extra dongás. (7mm)"

                 });
            modelBuilder.Entity<Image>().HasData(
                new Image
                {
                    ImageId = Guid.Parse("babbf4a6-d5ec-4054-b2e8-2b5c508a947a"),
                    ArrowId = Guid.Parse("97bcd962-2a0d-4489-8e48-19dd2c848893"),
                    Size = 563,
                    ImageSource = "/images/bfb1.jpg"
                },
                new Image
                {
                    ImageId = Guid.Parse("088f9fb0-70b6-49e0-b80a-cca1dd3c631a"),
                    ArrowId = Guid.Parse("e71847d9-1ddb-4db1-8af5-801803d6151c"),
                    Size = 467,
                    ImageSource = "/images/ujpest1.jpg"
                },
                new Image
                {
                    ImageId = Guid.Parse("211aee93-89cb-46d4-b946-e8f4c7d938c9"),
                    ArrowId = Guid.Parse("019e54c4-5a54-42d3-a78a-8b3d9dd0d85d"),
                    Size = 351,
                    ImageSource = "/images/svb1.jpg"
                });
        }
    }
}
