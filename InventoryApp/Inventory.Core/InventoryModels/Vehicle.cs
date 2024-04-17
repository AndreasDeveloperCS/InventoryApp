using Inventory.Core.Enums;

namespace Inventory.Core.InventoryModels
{
    public class Vehicle: IComparable
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

        public int CompareTo(object? obj)
        {
            int nameComparison = string.Compare(GetType().Name, obj?.GetType().Name, StringComparison.OrdinalIgnoreCase);
            if (nameComparison != 0)
            {
                return nameComparison;
            }
            return 1;
        }

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
