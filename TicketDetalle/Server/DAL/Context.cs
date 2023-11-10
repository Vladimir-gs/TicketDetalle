using Microsoft.EntityFrameworkCore;
using TicketDetalle.Shared;

namespace TicketDetalle.Server.DAL
{
    public class Context : DbContext
    {
        public DbSet<Tickets> Tickets { get; set; }

        public Context(DbContextOptions<Context> options)
            :base(options){ }
    }
}
