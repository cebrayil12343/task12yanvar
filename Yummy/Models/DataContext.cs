using Microsoft.EntityFrameworkCore;

namespace Yummy.Models
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Slider> Sliders { get; set; }
    }
}
