using System;
using Microsoft.EntityFrameworkCore;

namespace intex2.Models
{
    public class CrashModelContext: DbContext
    {
        public CrashModelContext(DbContextOptions<CrashModelContext> options) : base(options) { }

        public DbSet<CrashModel> Crashes { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {

            mb.Entity<CrashModelContext>().HasData(
               new CrashModel
               {
              
               }
           );

        }

    }
}
