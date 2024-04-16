using Inventory.Core.Enums;

namespace Inventory.Core.InventoryModels
{
    public class Boat : Vehicle
    {
        public Boat(string make, string model, VehicleEnvironment environment,
            string photoName, int engines, float lengthFt, int guestCount,
            string description)
            : base(make, model, environment, photoName)
        {
            Engines = engines;
            LengthFt = lengthFt;
            GuestCount = guestCount;
            Description = description;
        }

        public int Engines { get; private set; }
        public float LengthFt { get; private set; }
        public int GuestCount { get; private set; }
        public string Description { get; private set; }
    }

}
