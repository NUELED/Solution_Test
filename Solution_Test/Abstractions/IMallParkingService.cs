using Solution_Test.Models.Utilities;

namespace Solution_Test.Abstractions
{
    public interface IMallParkingService
    {

        ParkingReceipt GetRcptById001(int Id);
        ParkingReceipt GetRcptById002(int Id);
        ParkingReceipt GetRcptById003(int Id);
        ParkingTicket GetTktById001(string TicketNumber);
        ParkingTicket GetTktById002(string TicketNumber);
        ParkingTicket GetTktById003(string TicketNumber);
    }
}
