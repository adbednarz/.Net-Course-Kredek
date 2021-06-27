﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdamBednarzLab8ZadDom.Models
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {


        }

        public DbSet<Museum> Museums { get; set; }

        public DbSet<ArtWork> ArtWorks { get; set; }

        public DbSet<Artist> Artists { get; set; }

    }
}
