using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace GrpcServer.DBContexts
{
    public class VanzariDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"data source=file:D:\\anu 2\\sem2\\Databases\\vanzari");
        }

        public DbSet<Angajat> Angajati { get; set; }
        public DbSet<Produs> Produse { get; set; }
    }
}
