namespace Solution_Test.Models.Utilities
{
    public class ParkingSpot
    {

        public int Number { get; }
        public bool IsOccupied { get; private set; }
        public DateTime? EntryTime { get; private set; }

        public ParkingSpot(int number)
        {
            Number = number;
        }

        public void Park(DateTime entryTime)
        {
            IsOccupied = true;
            EntryTime = entryTime;
        }

        public void Unpark()
        {
            IsOccupied = false;
            EntryTime = null;
        }
    }




}
