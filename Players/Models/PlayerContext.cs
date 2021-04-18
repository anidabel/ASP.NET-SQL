using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Players.Models
{
    public class PlayerContext : DbContext
    {
        public DbSet<Player> players { get; set; }
        public PlayerContext(DbContextOptions<PlayerContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
