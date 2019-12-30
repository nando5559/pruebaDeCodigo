﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudPeliculas.Models
{
    public class Pelicula
    {
        public int Id { get; set; }
        public string Titulo { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaEstreno { get; set; }
        public string Genero { get; set; }
        public decimal Precio { get; set; }

    }
}
