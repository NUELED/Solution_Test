using Solution_Test.Abstractions;
using Solution_Test.Models.FeeModels.FeeIntervals;
using Solution_Test.Models.FeeModels;
using Solution_Test.Models;
using Solution_Test.Models.Utilities;

namespace Solution_Test.Implementations
{
    public class StadiumParkingService : IStadiumParkingService
    {
        List<ParkingTicket> parkingTickets = new List<ParkingTicket>();


        private StadiumFeeModel stadiumFeeModel_Car_SUV;

       

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



        public ParkingReceipt GetRcptById001(int TicketNumber)
        {
            
           
            var f = new ParkingReceipt()
            {
                //Id = TicketNumber,
                ReceiptNumber = "R-001",
                EntryDateTime = DateTime.Now,
                ExitDateTime = DateTime.MaxValue,
                Fee = 30

            };

            return f;
        }


        public ParkingReceipt GetRcptById002(int TicketNumber)
        {

           
            var f = new ParkingReceipt()
            {
                // Id = TicketNumber,
                ReceiptNumber = "R-002",
                EntryDateTime = DateTime.Now,
                ExitDateTime = DateTime.MaxValue,
                Fee = 390

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
                Fee = 180

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
                Fee = 580

            };

            return f;
        }



        //public ParkingReceipt GetTById(int Id)
        //{
        //     throw new NotImplementedException();

        //}

        //public decimal MotorcycleFee(TimeSpan parkedDuration, VehicleType vehicleType)
        //{

        //    decimal fee = 0;
        //    List<StadiumFeeInterval> feeIntervals = null;

        //    if (vehicleType == VehicleType.Motorcycles_Scooters)
        //    {
        //        feeIntervals = stadiumFeeModel_Car_SUV.FeeIntervals_Motorcycle;
        //    }
        //    else
        //    {
        //        // Throw an exception if the vehicle type is not supported
        //        throw new ArgumentException("Invalid vehicle type.");
        //    }

        //    foreach (StadiumFeeInterval interval in feeIntervals)
        //    {
        //        if (parkedDuration < interval.EndTime)
        //        {
        //            TimeSpan intervalDuration = parkedDuration - interval.StartTime;
        //            if (intervalDuration > TimeSpan.Zero)
        //            {
        //                fee += (decimal)intervalDuration.TotalHours * interval.Fee;
        //            }
        //            break;
        //        }
        //        else
        //        {
        //            TimeSpan intervalDuration = interval.EndTime - interval.StartTime;
        //            fee += (decimal)intervalDuration.TotalHours * interval.Fee;
        //        }
        //    }

        //    return fee;
        //}




        //public decimal SuvFee(TimeSpan parkedDuration, VehicleType vehicleType)
        //    {

        //        decimal fee = 0;
        //        List<StadiumFeeInterval> feeIntervals = null;

        //        if (vehicleType == VehicleType.Cars_SUVs)
        //        {
        //            feeIntervals = stadiumFeeModel_Car_SUV.FeeIntervals_Car_SUV;
        //        }
        //        else
        //        {
        //            // Throw an exception if the vehicle type is not supported
        //            throw new ArgumentException("Invalid vehicle type.");
        //        }

        //        foreach (StadiumFeeInterval interval in feeIntervals)
        //        {
        //            if (parkedDuration < interval.EndTime)
        //            {
        //                TimeSpan intervalDuration = parkedDuration - interval.StartTime;
        //                if (intervalDuration > TimeSpan.Zero)
        //                {
        //                    fee += (decimal)intervalDuration.TotalHours * interval.Fee;
        //                }
        //                break;
        //            }
        //            else
        //            {
        //                TimeSpan intervalDuration = interval.EndTime - interval.StartTime;
        //                fee += (decimal)intervalDuration.TotalHours * interval.Fee;
        //            }
        //        }

        //        return fee;        
        //}



        //public decimal TruckFee(TimeSpan parkedDuration, VehicleType vehicleType)
        //{

        //    decimal fee = 0;
        //    List<StadiumFeeInterval> feeIntervals = null;

        //    if (vehicleType == VehicleType.Buses_Trucks)
        //    {
        //        feeIntervals = stadiumFeeModel_Car_SUV.FeeIntervals_Trucks_Buses;
        //    }
        //    else
        //    {
        //        // Throw an exception if the vehicle type is not supported
        //        throw new ArgumentException("Invalid vehicle type.");
        //    }

        //    foreach (StadiumFeeInterval interval in feeIntervals)
        //    {
        //        if (parkedDuration < interval.EndTime)
        //        {
        //            TimeSpan intervalDuration = parkedDuration - interval.StartTime;
        //            if (intervalDuration > TimeSpan.Zero)
        //            {
        //                fee += (decimal)intervalDuration.TotalHours * interval.Fee;
        //            }
        //            break;
        //        }
        //        else
        //        {
        //            TimeSpan intervalDuration = interval.EndTime - interval.StartTime;
        //            fee += (decimal)intervalDuration.TotalHours * interval.Fee;
        //        }
        //    }

        //    return fee;
        //}



    }
}
