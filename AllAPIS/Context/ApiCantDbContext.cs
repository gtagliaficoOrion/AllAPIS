using AllAPIS.Entities;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllAPIS.Context
{
    public class ApiCantDbContext: DbContext
    {
        public ApiCantDbContext(DbContextOptions<ApiCantDbContext> options): base(options)
        {

        }

        public DbSet<M66005> M66005 { get; set; }
        public DbSet<M66006> M66006 { get; set; }
        public DbSet<M66004> M66004 { get; set; }
        public DbSet<T69003> T69003 { get; set; }
        public DbSet<M10012> M10012 { get; set; }

    }
}
