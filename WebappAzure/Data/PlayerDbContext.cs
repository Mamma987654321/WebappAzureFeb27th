using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebappAzure.Models;

namespace WebappAzure.Data
{
    public class PlayerDbContext : DbContext
    {
        public PlayerDbContext (DbContextOptions<PlayerDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebappAzure.Models.Player> Player { get; set; } = default!;
    }
}
