using NuGet.DependencyResolver;
using System.ComponentModel;

namespace HannesMalterRoadTransport.Models
{
    public class OrdersWithoutDriver
    {
        public int Id { get; set; }
        [DisplayName("Company Name")]
        public string Name { get; set; }
        [DisplayName("My location")]
        public string StartingLocation { get; set; }
        public int Quantity { get; set; }
        [DisplayName("Time of delivery")]
        public DateTime ETA { get; set; }
        public string? CarNR { get; set; }
        public string? Driver { get; set; }
    }
}
