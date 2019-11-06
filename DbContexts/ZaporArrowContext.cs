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
    }
}
