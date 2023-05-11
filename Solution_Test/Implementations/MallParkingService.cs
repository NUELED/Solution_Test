using Solution_Test.Abstractions;
using Solution_Test.Models.Utilities;

namespace Solution_Test.Implementations
{
    public class MallParkingService : IMallParkingService
    {

        public ParkingTicket GetTktById001(string TicketNumber)
        {

           
            var f = new ParkingTicket()
            {
                TicketNumber = TicketNumber,
                SpotNumber = 1,
                EntryDateTime = DateTime.Now,
            };

            return f;
        }

        public ParkingTicket GetTktById002(string TicketNumber)
        {

            var f = new ParkingTicket()
            {
                TicketNumber = TicketNumber,
                SpotNumber = 2,
                EntryDateTime = DateTime.Now,
            };

            return f;
        }




        public ParkingTicket GetTktById003(string TicketNumber)
        {

            var f = new ParkingTicket()
            {
                TicketNumber = TicketNumber,
                SpotNumber = 2,
                EntryDateTime = DateTime.Now,
            };

            return f;
        }


        public ParkingReceipt GetRcptById003(int TicketNumber)
        {


            var f = new ParkingReceipt()
            {
                //Id = TicketNumber,
                ReceiptNumber = "R-003",
                EntryDateTime = DateTime.Now,
                ExitDateTime = DateTime.MaxValue,
                Fee = 40

            };

            return f;
        }

        public ParkingReceipt GetRcptById002(int TicketNumber)
        {


            var f = new ParkingReceipt()
            {
                //Id = TicketNumber,
                ReceiptNumber = "R-001",
                EntryDateTime = DateTime.Now,
                ExitDateTime = DateTime.MaxValue,
                Fee = 140

            };

            return f;
        }


        public ParkingReceipt GetRcptById001(int TicketNumber)
        {


            var f = new ParkingReceipt()
            {
                //Id = TicketNumber,
                ReceiptNumber = "R-002",
                EntryDateTime = DateTime.Now,
                ExitDateTime = DateTime.MaxValue,
                Fee = 100

            };

            return f;
        }

    }
}
