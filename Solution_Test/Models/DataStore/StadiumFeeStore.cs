using Solution_Test.Models.FeeModels.FeeIntervals;
using Solution_Test.Models.FeeModels;

namespace Solution_Test.Models
{
    public  class StadiumFeeStore
    {
         StadiumFeeModel  stadiumFeeModel_Motorcycle = new StadiumFeeModel()
        {
            FlatRateFee = 0,
            FeeIntervals_Motorcycle = new List<StadiumFeeInterval>
                {
                      new StadiumFeeInterval { StartTime = TimeSpan.Zero, EndTime = TimeSpan.FromHours(4), Fee = 30 },
                      new StadiumFeeInterval { StartTime = TimeSpan.FromHours(4), EndTime = TimeSpan.FromHours(12), Fee = 60 },
                      new StadiumFeeInterval { StartTime = TimeSpan.FromHours(12), EndTime = TimeSpan.MaxValue, Fee = 100 },
                }
        };



        StadiumFeeModel stadiumFeeModel_Car_SUV = new StadiumFeeModel()
        {
            FlatRateFee = 0,
            FeeIntervals_Car_SUV = new List<StadiumFeeInterval>
                {
                      new StadiumFeeInterval { StartTime = TimeSpan.Zero, EndTime = TimeSpan.FromHours(4), Fee = 60 },
                      new StadiumFeeInterval { StartTime = TimeSpan.FromHours(4), EndTime = TimeSpan.FromHours(12), Fee = 120 },
                      new StadiumFeeInterval { StartTime = TimeSpan.FromHours(12), EndTime = TimeSpan.MaxValue, Fee = 200 },
                }
        };


    }
}
