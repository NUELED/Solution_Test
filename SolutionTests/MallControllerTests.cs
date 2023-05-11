using Microsoft.AspNetCore.Mvc;
using Moq;
using Solution_Test.Abstractions;
using Solution_Test.Controllers;
using Solution_Test.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionTests
{
    public class MallControllerTests
    {

        private readonly Mock<IMallParkingService> _mockMallParkingService;
        private readonly MallController _controller;

        public MallControllerTests()
        {
            _mockMallParkingService = new Mock<IMallParkingService>();
            _controller = new MallController(_mockMallParkingService.Object);
        }

        [Fact]
        public void GetTicketBy1_ReturnsOk()
        {
            // Arrange
            string ticketNumber = "001";
            //var expectedResult = "Some result";
            var expectedResult = new ParkingTicket { TicketNumber = "001", SpotNumber = 1, EntryDateTime = DateTime.Now };
            _mockMallParkingService.Setup(x => x.GetTktById001(ticketNumber)).Returns(expectedResult);

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
            _mockMallParkingService.Setup(x => x.GetTktById001(ticketNumber)).Returns(expectedResult);

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
            _mockMallParkingService.Setup(x => x.GetTktById001(ticketNumber)).Returns(expectedResult);

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
            _mockMallParkingService.Setup(x => x.GetRcptById001(ticketNumber)).Returns(expectedResult);

            // Act
            var result = _controller.GetReceiptBy(ticketNumber);

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
            var expectedResult = new ParkingReceipt { ReceiptNumber = "R-002", Fee = 140, EntryDateTime = DateTime.Now, ExitDateTime = DateTime.MaxValue };
            _mockMallParkingService.Setup(x => x.GetRcptById001(ticketNumber)).Returns(expectedResult);

            // Act
            var result = _controller.GetReceiptBy2(ticketNumber);

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
            var expectedResult = new ParkingReceipt { ReceiptNumber = "R-003", Fee = 40, EntryDateTime = DateTime.Now, ExitDateTime = DateTime.MaxValue };
            _mockMallParkingService.Setup(x => x.GetRcptById001(ticketNumber)).Returns(expectedResult);

            // Act
            var result = _controller.GetReceiptBy3(ticketNumber);

            // Assert
            Assert.IsType<OkObjectResult>(result);
            var okResult = result as OkObjectResult;
            Assert.Equal(expectedResult, okResult.Value);
        }


      

    }
}
