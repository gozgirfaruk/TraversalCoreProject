using Microsoft.EntityFrameworkCore;

namespace SignalRApi.DAL
{
    public class SignalContext : DbContext
    {
        public SignalContext(DbContextOptions<SignalContext>options):base(options)
        {
            
        }
        public DbSet<Visitor> Visitors { get; set; }
    }
}
