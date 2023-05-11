using Solution_Test.Models;
using Solution_Test.Models.Utilities;
using static Solution_Test.Implementations.ParkingService;

namespace Solution_Test.Implementations
{
    public class ParkingService
    {


      
            private readonly Dictionary<VehicleType, List<ParkingSpot>> _spots = new();

           



            public bool IsSpotAvailable(VehicleType vehicleType)
            {
                return _spots[vehicleType].Any(spot => !spot.IsOccupied);
            }



            public ParkingSpot ParkVehicle(VehicleType vehicleType, DateTime entryTime)
            {
                var availableSpot = _spots[vehicleType].FirstOrDefault(spot => !spot.IsOccupied);

                if (availableSpot != null)
                {
                    availableSpot.Park(entryTime);
                    return availableSpot;
                }

                return null;
            }


     
    }




    
}
