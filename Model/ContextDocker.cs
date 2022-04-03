using Microsoft.EntityFrameworkCore;

namespace docker.api.Model
{
    public class ContextDocker : DbContext
    {
        public ContextDocker(DbContextOptions<ContextDocker> options) : base(options)
        {

        }

        public DbSet<Pessoa> Pessoa { get; set; }
    }
}