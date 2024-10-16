using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JoseCarvajal_MVC2.Models;

namespace JoseCarvajal_MVC2.Data
{
    public class JoseCarvajal_MVC2Context : DbContext
    {
        public JoseCarvajal_MVC2Context (DbContextOptions<JoseCarvajal_MVC2Context> options)
            : base(options)
        {
        }

        public DbSet<JoseCarvajal_MVC2.Models.Equipo> Equipo { get; set; } = default!;
        public DbSet<JoseCarvajal_MVC2.Models.Jugador> Jugador { get; set; } = default!;
        public DbSet<JoseCarvajal_MVC2.Models.Estadio> Estadio { get; set; } = default!;
    }
}
