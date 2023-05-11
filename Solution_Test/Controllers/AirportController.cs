using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Solution_Test.Abstractions;
using Solution_Test.Implementations;

namespace Solution_Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirportController : ControllerBase
    {
        private readonly IAirportParkingService _airportParkingService;

        public AirportController(IAirportParkingService airportParkingService)
        {
            _airportParkingService = airportParkingService; 
        }





        [HttpGet]
        [Route("GetTicketById001")]
        public IActionResult GetTicketBy1(string ticketNumber)
        {
            var f = _airportParkingService.GetTktById001(ticketNumber);
            return Ok(f);
        }


        [HttpGet]
        [Route("GetTicketById002")]
        public IActionResult GetTicketBy2(string ticketNumber)
        {
            var f = _airportParkingService.GetTktById002(ticketNumber);
            return Ok(f);
        }



        [HttpGet]
        [Route("GetTicketById003")]
        public IActionResult GetTicketBy3(string ticketNumber)
        {
            var f = _airportParkingService.GetTktById003(ticketNumber);
            return Ok(f);
        }




        [HttpGet]
        [Route("GetTicketById004")]
        public IActionResult GetTicketBy4(string ticketNumber)
        {
            var f = _airportParkingService.GetTktById004(ticketNumber);
            return Ok(f);
        }

        [HttpGet]
        [Route("GetTicketById005")]
        public IActionResult GetTicketBy5(string ticketNumber)
        {
            var f = _airportParkingService.GetTktById005(ticketNumber);
            return Ok(f);
        }

        [HttpGet]
        [Route("GetTicketById006")]
        public IActionResult GetTicketBy6(string ticketNumber)
        {
            var f = _airportParkingService.GetTktById006(ticketNumber);
            return Ok(f);
        }

        //--------------------------

        [HttpGet]
        [Route("GetReceiptByTicketNumber006")]
        public IActionResult GetReceiptBy6(int TicketNumber)
        {
            var f = _airportParkingService.GetRcptById006(TicketNumber);
            return Ok(f);
        }


        [HttpGet]
        [Route("GetReceiptByTicketNumber005")]
        public IActionResult GetReceiptBy5(int TicketNumber)
        {
            var f = _airportParkingService.GetRcptById005(TicketNumber);
            return Ok(f);
        }


        [HttpGet]
        [Route("GetReceiptByTicketNumber004")]
        public IActionResult GetReceiptBy4(int TicketNumber)
        {
            var f = _airportParkingService.GetRcptById004(TicketNumber);
            return Ok(f);
        }


        [HttpGet]
        [Route("GetReceiptByTicketNumber003")]
        public IActionResult GetReceiptBy3(int TicketNumber)
        {
            var f = _airportParkingService.GetRcptById003(TicketNumber);
            return Ok(f);
        }



        [HttpGet]
        [Route("GetReceiptByTicketNumber002")]
        public IActionResult GetReceiptBy2(int TicketNumber)
        {
            var f = _airportParkingService.GetRcptById002(TicketNumber);
            return Ok(f);
        }


        [HttpGet]
        [Route("GetReceiptByTicketNumber001")]
        public IActionResult GetReceiptBy1(int TicketNumber)
        {
            var f = _airportParkingService.GetRcptById001(TicketNumber);
            return Ok(f);
        }









    }
}
