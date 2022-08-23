
using AllAPIS.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllAPIS.Context
{
    public class CuentasDbContext : DbContext
    {
        public CuentasDbContext(DbContextOptions<CuentasDbContext> options) : base(options)
        {

        }

        public DbSet<T41001> T41001 { get; set; }
        public DbSet<T41002> T41002 { get; set; }
        public DbSet<T41003> T41003 { get; set; }
        public DbSet<T62003> T62003 { get; set; }
        public DbSet<T62004> T62004 { get; set; }
        public DbSet<M64001> M64001 { get; set; }
        public DbSet<M10012> M10012 { get; set; }
        



    }
}
