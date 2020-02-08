using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HomeWork2_EFCoreWithRazorPages.Models;

namespace HomeWork2_EFCoreWithRazorPages.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext (DbContextOptions<SchoolContext> options)
            : base(options)
        {
        }

        public DbSet<HomeWork2_EFCoreWithRazorPages.Models.Student> Student { get; set; }
    }
}
