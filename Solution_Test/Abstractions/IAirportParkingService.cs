using Solution_Test.Models.Utilities;

namespace Solution_Test.Abstractions
{
    public interface IAirportParkingService 
    {
        ParkingReceipt GetRcptById001(int Id);
        ParkingReceipt GetRcptById002(int Id);
        ParkingReceipt GetRcptById003(int Id);
        ParkingReceipt GetRcptById004(int Id);
        ParkingReceipt GetRcptById005(int Id);
        ParkingReceipt GetRcptById006(int Id);
        ParkingTicket GetTktById001(string TicketNumber);
        ParkingTicket GetTktById002(string TicketNumber);
        ParkingTicket GetTktById003(string TicketNumber);
        ParkingTicket GetTktById004(string TicketNumber);
        ParkingTicket GetTktById005(string TicketNumber);
        ParkingTicket GetTktById006(string TicketNumber);
    }
}
