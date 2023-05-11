using System.Net.Sockets;

namespace Solution_Test.Models.Utilities
{
    public class ParkingTicket
    {
        public string TicketNumber { get; set; }
        public float SpotNumber { get; set; }
        public DateTime EntryDateTime { get; set; } = DateTime.Now;   
    }

}
