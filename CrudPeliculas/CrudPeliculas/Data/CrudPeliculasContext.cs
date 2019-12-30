using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CrudPeliculas.Models
{
    public class CrudPeliculasContext : DbContext
    {
        public CrudPeliculasContext (DbContextOptions<CrudPeliculasContext> options)
            : base(options)
        {
        }

        public DbSet<Pelicula> Pelicula { get; set; }
    }
}
