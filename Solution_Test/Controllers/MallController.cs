using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Solution_Test.Abstractions;
using Solution_Test.Implementations;

namespace Solution_Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MallController : ControllerBase
    {
        private readonly IMallParkingService _mallParkingService;
        public MallController(IMallParkingService mallParkingService)
        {
            _mallParkingService = mallParkingService;
        }



        [HttpGet]
        [Route("GetTicketById001")]
        public IActionResult GetTicketBy1(string ticketNumber)
        {
            var f = _mallParkingService.GetTktById001(ticketNumber);
            return Ok(f);
        }


        [HttpGet]
        [Route("GetTicketById002")]
        public IActionResult GetTicketBy2(string ticketNumber)
        {
            var f = _mallParkingService.GetTktById002(ticketNumber);
            return Ok(f);
        }



        [HttpGet]
        [Route("GetTicketById003")]
        public IActionResult GetTicketBy3(string ticketNumber)
        {
            var f = _mallParkingService.GetTktById002(ticketNumber);
            return Ok(f);
        }



        [HttpGet]
        [Route("GetReceiptByTicketNumber001")]
        public IActionResult GetReceiptBy(int TicketNumber)
        {
            var f = _mallParkingService.GetRcptById001(TicketNumber);
            return Ok(f);
        }



        [HttpGet]
        [Route("GetReceiptByTicketNumber002")]
        public IActionResult GetReceiptBy2(int TicketNumber)
        {
            var f = _mallParkingService.GetRcptById002(TicketNumber);
            return Ok(f);
        }


        [HttpGet]
        [Route("GetReceiptByTicketNumber003")]
        public IActionResult GetReceiptBy3(int TicketNumber)
        {
            var f = _mallParkingService.GetRcptById003(TicketNumber);
            return Ok(f);
        }





    }
}
