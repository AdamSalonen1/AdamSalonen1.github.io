using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HomeworkHelper.Models;

namespace HomeworkHelper.Data
{
    public class HomeworkHelperContext : DbContext
    {
        public HomeworkHelperContext (DbContextOptions<HomeworkHelperContext> options)
            : base(options)
        {
        }

        public DbSet<HomeworkHelper.Models.Assignments> Assignments { get; set; } = default!;
    }
}
