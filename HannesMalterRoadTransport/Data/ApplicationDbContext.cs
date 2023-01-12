using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using HannesMalterRoadTransport.Models;

namespace HannesMalterRoadTransport.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<HannesMalterRoadTransport.Models.Transport> Transport { get; set; }
        public DbSet<HannesMalterRoadTransport.Models.Order> Order { get; set; }
        public DbSet<HannesMalterRoadTransport.Models.OrdersWithoutDriver> OrdersWithoutDriver { get; set; }
        public object TransportationOrders { get; internal set; }
    }
}