using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Solution_Test.Abstractions;
using Solution_Test.Implementations;

namespace Solution_Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StadiumController : ControllerBase
    {

        private readonly IStadiumParkingService _ParkingService;

        public StadiumController( IStadiumParkingService stadiumParkingService)
        {
           _ParkingService = stadiumParkingService;    
        }



        [HttpGet]
        [Route("GetTicketById001")]
        public IActionResult GetTicketBy1(string ticketNumber)
        {
            var f = _ParkingService.GetTktById001(ticketNumber);
            return Ok(f);
        }


        [HttpGet]
        [Route("GetTicketById002")]
        public IActionResult GetTicketBy2(string ticketNumber)
        {
            var f = _ParkingService.GetTktById002(ticketNumber);
            return Ok(f);
        }



        [HttpGet]
        [Route("GetTicketById003")]
        public IActionResult GetTicketBy3(string ticketNumber)
        {
            var f = _ParkingService.GetTktById003(ticketNumber);
            return Ok(f);
        }




        [HttpGet]
        [Route("GetTicketById004")]
        public IActionResult GetTicketBy4(string ticketNumber)
        {
            var f = _ParkingService.GetTktById004(ticketNumber);
            return Ok(f);
        }





        [HttpGet]
        [Route("GetReceiptByTicketNumber004")]
        public IActionResult GetReceiptBy4(int TicketNumber)
        {
            var f = _ParkingService.GetRcptById004(TicketNumber);
            return Ok(f);
        }


        [HttpGet]
        [Route("GetReceiptByTicketNumber003")]
        public IActionResult GetReceiptBy3(int TicketNumber)
        {
            var f = _ParkingService.GetRcptById003(TicketNumber);
            return Ok(f);
        }



        [HttpGet]
        [Route("GetReceiptByTicketNumber002")]
        public IActionResult GetReceiptBy2(int TicketNumber)
        {
            var f = _ParkingService.GetRcptById002(TicketNumber);
            return Ok(f);
        }


        [HttpGet]
        [Route("GetReceiptByTicketNumber001")]
        public IActionResult GetReceiptBy1(int TicketNumber)
        {
            var f = _ParkingService.GetRcptById001(TicketNumber);
            return Ok(f);
        }







    }
}
