using Microsoft.EntityFrameworkCore;

namespace land_forcesAPI.Data
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<landforcesEP> landforcesEPs { get; set; }
    }
}
