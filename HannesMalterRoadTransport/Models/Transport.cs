using System.ComponentModel;

namespace HannesMalterRoadTransport.Models
{
    public class Transport
    {
        // 1,Chair Company,Rakvere, Vilnius, 22/11/2022 18:05, BDT 123, John, Ready
        public int Id { get; set; }

        [DisplayName("Company Name")]
        public string Name { get; set; }

        [DisplayName("Starting Location")]
        public string? StartingLocation { get; set; }

        [DisplayName("Destination")]
        public string? EndLocation { get; set; }

        [DisplayName("Estimated Time Of Arrival")]
        public DateTime ETA { get; set; }

        [DisplayName("Number plate")]
        public string? CarNR { get; set; }
        public string? Driver { get; set; }

        [DisplayName("Transport Status")]
        public string TrnspReady { get; set; }
    }
}
