using Solution_Test.Models.FeeModels.FeeIntervals;

namespace Solution_Test.Models.FeeModels
{
    public  class StadiumFeeModel
    {
        public  int FlatRateFee { get; set; }
        public  List<StadiumFeeInterval> FeeIntervals_Motorcycle { get; set; }
        public  List<StadiumFeeInterval> FeeIntervals_Car_SUV  { get; set; }
        public  List<StadiumFeeInterval> FeeIntervals_Trucks_Buses  { get; set; }
    }
}
