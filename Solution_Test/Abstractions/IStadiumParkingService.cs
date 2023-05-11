using Solution_Test.Models;
using Solution_Test.Models.Utilities;
using System.Security.Principal;

namespace Solution_Test.Abstractions
{
    public interface IStadiumParkingService
    {

        //-----
        ParkingReceipt GetRcptById001(int Id);
        ParkingReceipt GetRcptById002(int Id);
        ParkingReceipt GetRcptById003(int Id);
        ParkingReceipt GetRcptById004(int Id);
        ParkingTicket GetTktById001(string TicketNumber);
        ParkingTicket GetTktById002(string TicketNumber);
        ParkingTicket GetTktById003(string TicketNumber);
        ParkingTicket GetTktById004(string TicketNumber);
        //-----

    }
}
