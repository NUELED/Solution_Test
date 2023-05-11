using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Solution_Test.Abstractions;

namespace Solution_Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SmallMotocycleController : ControllerBase
    {


        private readonly ISmallMotorcycleParkingService _parkingService;
        public SmallMotocycleController( ISmallMotorcycleParkingService parkingService)
        {
            _parkingService = parkingService;   
        }



        [HttpGet]
        [Route("GetTicketById001")]
        public IActionResult GetTicketBy1(string ticketNumber)
        {
            var f = _parkingService.GetTktById001(ticketNumber);
            return Ok(f);
        }


        [HttpGet]
        [Route("GetTicketById002")]
        public IActionResult GetTicketBy2(string ticketNumber)
        {
            var f = _parkingService.GetTktById002(ticketNumber);
            return Ok(f);
        }



        [HttpGet]
        [Route("GetTicketById003")]
        public IActionResult GetTicketBy3(string ticketNumber)
        {
            var f = _parkingService.GetTktById002(ticketNumber);
            return Ok(f);
        }



        [HttpGet]
        [Route("GetReceiptByTicketNumber001")]
        public IActionResult GetReceiptBy(int TicketNumber)
        {
            var f = _parkingService.GetRcptById001(TicketNumber);
            return Ok(f);
        }



        [HttpGet]
        [Route("GetReceiptByTicketNumber002")]
        public IActionResult GetReceiptBy2(int TicketNumber)
        {
            var f = _parkingService.GetRcptById002(TicketNumber);
            return Ok(f);
        }






    }
}
