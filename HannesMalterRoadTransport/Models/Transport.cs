using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HannesMalterRoadTransport.Models
{
    public class Transport
    {
        // 1,Chair Company,Rakvere, Vilnius, 22/11/2022 18:05, BDT 123, John, Ready
        public int Id { get; set; }

        [DisplayName("Company Name")]
        [StringLength(80)]
        public string Name { get; set; }

        [DisplayName("Starting Location")]
        [StringLength(160)]
        public string StartingLocation { get; set; }

        [DisplayName("Destination")]
        [StringLength(160)]
        public string EndLocation { get; set; }

        [DisplayName("Estimated Time Of Arrival")]
        public DateTime ETA { get; set; }

        [DisplayName("Number plate")]
        [StringLength(20)]
        public string? CarNR { get; set; }
        [StringLength(30)]
        public string? Driver { get; set; }

        [DisplayName("Transport Status")]
        public string TrnspReady { get; set; } = "Not Ready";
    }
}