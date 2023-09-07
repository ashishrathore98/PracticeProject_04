using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PracticeProject_04.Model;

namespace PracticeProject_04.Data
{
    public class PracticeProject_04DbContext : DbContext
    {
        public PracticeProject_04DbContext (DbContextOptions<PracticeProject_04DbContext> options)
            : base(options)
        {
        }

        public DbSet<PracticeProject_04.Model.RainbowSchool> RainbowSchool { get; set; } = default!;
    }
}
