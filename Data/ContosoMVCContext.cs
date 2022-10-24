using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ContosoMVC.Models;

namespace ContosoMVC.Data
{
    public class ContosoMVCContext : DbContext
    {
        public ContosoMVCContext (DbContextOptions<ContosoMVCContext> options)
            : base(options)
        {
        }

        public DbSet<ContosoMVC.Models.Movie> Movie { get; set; } = default!;
    }
}
