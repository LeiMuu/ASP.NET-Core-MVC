using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebExercise.Models
{
    public class WebExerciseContext : DbContext
    {
        public WebExerciseContext (DbContextOptions<WebExerciseContext> options)
            : base(options)
        {
        }

        public DbSet<WebExercise.Models.Movie> Movie { get; set; }
    }
}
