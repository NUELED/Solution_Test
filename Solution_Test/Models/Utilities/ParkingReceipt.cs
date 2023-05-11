using System.Net.Sockets;

namespace Solution_Test.Models.Utilities
{
    public class ParkingReceipt
    {
      
      
        public string ReceiptNumber { get; set; }
        public decimal Fee { get; set; }
        public DateTime EntryDateTime { get; set; } = DateTime.Now;
        public DateTime ExitDateTime { get; set; }
      
    }
}
