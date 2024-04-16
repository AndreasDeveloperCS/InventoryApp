using Inventory.Core.Enums;

namespace Inventory.Core.InventoryModels
{
    public class Aeroplane : Vehicle
    {
        public Aeroplane(string make, string model, VehicleEnvironment environment,
                         string photoName, int numberOfEngines, int wheelCount,
                         int seatCount, double minRunwayLength)
            : base(make, model, environment, photoName)
        {
            NumberOfEngines = numberOfEngines;
            WheelCount = wheelCount;
            SeatCount = seatCount;
            MinRunwayLength = minRunwayLength;
        }

        public int NumberOfEngines { get; private set; }
        public int WheelCount { get; private set; }
        public int SeatCount { get; private set; }
        public double MinRunwayLength { get; private set; }
    }

}
