using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CursoWebMVC.Models;

namespace CursoWebMVC.Data
{
    public class CursoWebMVCContext : DbContext
    {
        public CursoWebMVCContext (DbContextOptions<CursoWebMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Department> SalesRecord { get; set; }
        public DbSet<Department> Saller { get; set; }
    }
}
