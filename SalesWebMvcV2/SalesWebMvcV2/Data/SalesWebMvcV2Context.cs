using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvcV2.Models;

namespace SalesWebMvcV2.Data
{
    public class SalesWebMvcV2Context : DbContext
    {
        public SalesWebMvcV2Context (DbContextOptions<SalesWebMvcV2Context> options)
            : base(options)
        {
        }

        public DbSet<SalesWebMvcV2.Models.Department> Department { get; set; }
    }
}
