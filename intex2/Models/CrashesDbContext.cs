﻿using System;
using Microsoft.EntityFrameworkCore;

namespace intex2.Models
{
    public class CrashesDbContext : DbContext
    {
        public CrashesDbContext(DbContextOptions<CrashesDbContext> options) : base(options) { }

        public DbSet<CrashModel> Crashes { get; set; }
    }
}
