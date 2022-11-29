using System.ComponentModel;

namespace HannesMalterRoadTransport.Models
{
    public class Order
    {
        // 1, Company, 50, 5/5/2022 14:50
        public int Id { get; set; }

        [DisplayName("Company Name")]
        public string Name { get; set; }


        public int Quantity { get; set; }

        [DisplayName("Time of delivery")]
        public DateTime ETA { get; set; }
    }
}
