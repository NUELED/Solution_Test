using Solution_Test.Models.FeeModels.FeeIntervals;
using Solution_Test.Models.FeeModels;

namespace Solution_Test.Models
{
    public class AirportFeeStore
    {

        AirportFeeModel AirportFeeModel_Motorcycle = new AirportFeeModel()
        {
            FlatRateFee = 10,
            FeeIntervals_Motorcycle = new List<AirportFeeInterval>
                {
                      new AirportFeeInterval { StartTime = TimeSpan.Zero, EndTime = TimeSpan.FromHours(1), Fee = 0 },
                      new AirportFeeInterval { StartTime = TimeSpan.FromHours(1), EndTime = TimeSpan.FromHours(8), Fee = 40 },
                      new AirportFeeInterval { StartTime = TimeSpan.FromHours(8), EndTime = TimeSpan.FromHours(24), Fee = 60 },
                      new AirportFeeInterval { StartTime = TimeSpan.FromDays(0), EndTime = TimeSpan.FromDays(1), Fee = 80 },
                }
        };



        AirportFeeModel AirportFeeModel_Car_SUV = new AirportFeeModel()
        {
            FlatRateFee = 20,
            FeeIntervals_Car_SUV = new List<AirportFeeInterval>
                {
                      new AirportFeeInterval { StartTime = TimeSpan.Zero, EndTime = TimeSpan.FromHours(12), Fee = 60 },
                      new AirportFeeInterval { StartTime = TimeSpan.FromHours(12), EndTime = TimeSpan.FromHours(24), Fee = 80 },
                      new AirportFeeInterval { StartTime = TimeSpan.FromDays(0), EndTime = TimeSpan.FromDays(1), Fee = 100 },
                }
        };

    }
}
