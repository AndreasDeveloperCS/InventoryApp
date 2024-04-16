using Inventory.Core.Enums;

namespace Inventory.Core.InventoryModels
{
    public class Vehicle
    {
        public Vehicle(string make, string model, VehicleEnvironment environment,
            string photoName)
        {
            PhotoName = photoName;
            Environment = environment;
            Model = model;
            Make = make;
        }
        public string Make { get; private set; }
        public string Model { get; private set; }
        public VehicleEnvironment Environment { get; private set; }
        public string PhotoName { get; private set; }

        public override bool Equals(object obj)
        {
            return obj is Vehicle && Equals((Vehicle)obj);
        }

        public bool Equals(Vehicle other)
        {
            bool flag = Make == other.Make
                        && Model == other.Model
                        && PhotoName == other.PhotoName
                        && Environment.ToString() == other.Environment.ToString();
            return flag;
        }

        public override int GetHashCode()
        {
            return Make.GetHashCode() ^ Model?.GetHashCode() ^ PhotoName?.GetHashCode() ^ Environment.ToString().GetHashCode() ?? 0;
        }
    }

}
