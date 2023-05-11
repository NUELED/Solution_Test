using Solution_Test.Models.FeeModels.FeeIntervals;

namespace Solution_Test.Models.FeeModels
{
    public  class AirportFeeModel
    {

        public  int FlatRateFee { get; set; }
        public  List<AirportFeeInterval> FeeIntervals_Motorcycle { get; set; }
        public  List<AirportFeeInterval> FeeIntervals_Car_SUV { get; set; }
        public  List<AirportFeeInterval> FeeIntervals_Trucks_Buses { get; set; }
    }
}
