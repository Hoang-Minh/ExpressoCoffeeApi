﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using ExpressoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpressoApi
{
    public class ExpressoDbContext : DbContext
    {
        public ExpressoDbContext(DbContextOptions<ExpressoDbContext> options) : base(options)
        {
            
        }

        public DbSet<Menu> Menu { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
    }
}
