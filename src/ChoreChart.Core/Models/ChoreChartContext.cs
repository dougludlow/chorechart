using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ChoreChart.Core.Models
{
    public class ChoreChartContext : DbContext
    {
        public ChoreChartContext(DbContextOptions<ChoreChartContext> options) : base(options)
        {
        }

        public DbSet<Chore> Chores { get; set; }
    }
}