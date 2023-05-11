using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solution_Test.Abstractions;
using Solution_Test.Controllers;
using Moq;
using Solution_Test.Models.FeeModels.FeeIntervals;
using Solution_Test.Models.Utilities;


namespace SolutionTests
{
    public class StadiumControllerTests
    {
        private readonly Mock<IStadiumParkingService> _mockAirportParkingService;
        private readonly StadiumController _controller;


        public StadiumControllerTests()
        {
            _mockAirportParkingService = new Mock<IStadiumParkingService>();
            _controller = new StadiumController(_mockAirportParkingService.Object);
        }


        [Fact]
        public void GetTicketBy1_ReturnsOk()
        {
            // Arrange
            string ticketNumber = "001";
            //var expectedResult = "Some result";
            var expectedResult = new ParkingTicket { TicketNumber = "001", SpotNumber = 1, EntryDateTime = DateTime.Now };
            _mockAirportParkingService.Setup(x => x.GetTktById001(ticketNumber)).Returns(expectedResult);

            // Act
            var result = _controller.GetTicketBy1(ticketNumber);

            // Assert
            Assert.IsType<OkObjectResult>(result);
            var okResult = result as OkObjectResult;
            Assert.Equal(expectedResult, okResult.Value);
        }


        [Fact]
        public void GetTicketBy2_ReturnsOk()
        {
            // Arrange
            string ticketNumber = "002";
            //var expectedResult = "Some result";
            var expectedResult = new ParkingTicket { TicketNumber = "002", SpotNumber = 2, EntryDateTime = DateTime.Now };
            _mockAirportParkingService.Setup(x => x.GetTktById001(ticketNumber)).Returns(expectedResult);

            // Act
            var result = _controller.GetTicketBy1(ticketNumber);

            // Assert
            Assert.IsType<OkObjectResult>(result);
            var okResult = result as OkObjectResult;
            Assert.Equal(expectedResult, okResult.Value);
        }



        [Fact]
        public void GetTicketBy3_ReturnsOk()
        {
            // Arrange
            string ticketNumber = "003";
            //var expectedResult = "Some result";
            var expectedResult = new ParkingTicket { TicketNumber = "003", SpotNumber = 3, EntryDateTime = DateTime.Now };
            _mockAirportParkingService.Setup(x => x.GetTktById001(ticketNumber)).Returns(expectedResult);

            // Act
            var result = _controller.GetTicketBy1(ticketNumber);

            // Assert
            Assert.IsType<OkObjectResult>(result);
            var okResult = result as OkObjectResult;
            Assert.Equal(expectedResult, okResult.Value);
        }


        [Fact]
        public void GetTicketBy4_ReturnsOk()
        {
            // Arrange
            string ticketNumber = "004";
            //var expectedResult = "Some result";
            var expectedResult = new ParkingTicket { TicketNumber = "004", SpotNumber = 4, EntryDateTime = DateTime.Now };
            _mockAirportParkingService.Setup(x => x.GetTktById001(ticketNumber)).Returns(expectedResult);

            // Act
            var result = _controller.GetTicketBy1(ticketNumber);

            // Assert
            Assert.IsType<OkObjectResult>(result);
            var okResult = result as OkObjectResult;
            Assert.Equal(expectedResult, okResult.Value);
        }






        [Fact]
        public void GetReceiptBy1_ReturnsOk()
        {
            // Arrange
            int ticketNumber = 001;
            var expectedResult = new ParkingReceipt { ReceiptNumber = "R-001", Fee = 30, EntryDateTime = DateTime.Now, ExitDateTime = DateTime.MaxValue };
            _mockAirportParkingService.Setup(x => x.GetRcptById001(ticketNumber)).Returns(expectedResult);

            // Act
            var result = _controller.GetReceiptBy1(ticketNumber);

            // Assert
            Assert.IsType<OkObjectResult>(result);
            var okResult = result as OkObjectResult;
            Assert.Equal(expectedResult, okResult.Value);
        }


        [Fact]
        public void GetReceiptBy2_ReturnsOk()
        {
            // Arrange
            int ticketNumber = 002;
            var expectedResult = new ParkingReceipt { ReceiptNumber = "R-002", Fee = 390, EntryDateTime = DateTime.Now, ExitDateTime = DateTime.MaxValue };
            _mockAirportParkingService.Setup(x => x.GetRcptById001(ticketNumber)).Returns(expectedResult);

            // Act
            var result = _controller.GetReceiptBy1(ticketNumber);

            // Assert
            Assert.IsType<OkObjectResult>(result);
            var okResult = result as OkObjectResult;
            Assert.Equal(expectedResult, okResult.Value);
        }


        [Fact]
        public void GetReceiptBy3_ReturnsOk()
        {
            // Arrange
            int ticketNumber = 003;
            var expectedResult = new ParkingReceipt { ReceiptNumber = "R-003", Fee = 180, EntryDateTime = DateTime.Now, ExitDateTime = DateTime.MaxValue };
            _mockAirportParkingService.Setup(x => x.GetRcptById001(ticketNumber)).Returns(expectedResult);

            // Act
            var result = _controller.GetReceiptBy1(ticketNumber);

            // Assert
            Assert.IsType<OkObjectResult>(result);
            var okResult = result as OkObjectResult;
            Assert.Equal(expectedResult, okResult.Value);
        }


        [Fact]
        public void GetReceiptBy4_ReturnsOk()
        {
            // Arrange
            int ticketNumber = 004;
            var expectedResult = new ParkingReceipt { ReceiptNumber = "R-004", Fee = 580, EntryDateTime = DateTime.Now, ExitDateTime = DateTime.MaxValue };
            _mockAirportParkingService.Setup(x => x.GetRcptById001(ticketNumber)).Returns(expectedResult);

            // Act
            var result = _controller.GetReceiptBy1(ticketNumber);

            // Assert
            Assert.IsType<OkObjectResult>(result);
            var okResult = result as OkObjectResult;
            Assert.Equal(expectedResult, okResult.Value);
        }



    }
}
