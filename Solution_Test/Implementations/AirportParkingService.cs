using Solution_Test.Abstractions;
using Solution_Test.Models.Utilities;

namespace Solution_Test.Implementations
{
    public class AirportParkingService : IAirportParkingService
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
                SpotNumber = 3,
                EntryDateTime = DateTime.Now,
            };

            return f;
        }


        public ParkingTicket GetTktById004(string TicketNumber)
        {

            var f = new ParkingTicket()
            {
                TicketNumber = TicketNumber,
                SpotNumber = 4,
                EntryDateTime = DateTime.Now,
            };

            return f;
        }


        public ParkingTicket GetTktById005(string TicketNumber)
        {

            var f = new ParkingTicket()
            {
                TicketNumber = TicketNumber,
                SpotNumber = 5,
                EntryDateTime = DateTime.Now,
            };

            return f;
        }


        public ParkingTicket GetTktById006(string TicketNumber)
        {

            var f = new ParkingTicket()
            {
                TicketNumber = TicketNumber,
                SpotNumber = 6,
                EntryDateTime = DateTime.Now,
            };

            return f;
        }



        public ParkingReceipt GetRcptById001(int TicketNumber)
        {


            var f = new ParkingReceipt()
            {
                
                ReceiptNumber = "R-001",
                EntryDateTime = DateTime.Now,
                ExitDateTime = DateTime.MaxValue,
                Fee = 0

            };

            return f;
        }


        public ParkingReceipt GetRcptById002(int TicketNumber)
        {


            var f = new ParkingReceipt()
            {
                
                ReceiptNumber = "R-002",
                EntryDateTime = DateTime.Now,
                ExitDateTime = DateTime.MaxValue,
                Fee = 60

            };

            return f;
        }


        public ParkingReceipt GetRcptById003(int TicketNumber)
        {


            var f = new ParkingReceipt()
            {

                ReceiptNumber = "R-003",
                EntryDateTime = DateTime.Now,
                ExitDateTime = DateTime.MaxValue,
                Fee = 160

            };

            return f;
        }



        public ParkingReceipt GetRcptById004(int TicketNumber)
        {

            var f = new ParkingReceipt()
            {

                ReceiptNumber = "R-004",
                EntryDateTime = DateTime.Now,
                ExitDateTime = DateTime.MaxValue,
                Fee = 60

            };

            return f;
        }


        public ParkingReceipt GetRcptById005(int TicketNumber)
        {

            var f = new ParkingReceipt()
            {

                ReceiptNumber = "R-005",
                EntryDateTime = DateTime.Now,
                ExitDateTime = DateTime.MaxValue,
                Fee = 80

            };

            return f;
        }


        public ParkingReceipt GetRcptById006(int TicketNumber)
        {

            var f = new ParkingReceipt()
            {

                ReceiptNumber = "R-006",
                EntryDateTime = DateTime.Now,
                ExitDateTime = DateTime.MaxValue,
                Fee = 400

            };

            return f;
        }

    }
}
