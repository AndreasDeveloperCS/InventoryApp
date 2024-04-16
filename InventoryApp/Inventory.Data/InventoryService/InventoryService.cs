using Inventory.Core.Enums;
using Inventory.Core.InventoryModels;
using Inventory.Core.InventoryService;

namespace Inventory.Data.InventoryService
{
    public class InventoryService : IInventoryService
    {
        private static readonly List<InventoryItem> InventoryItems = new List<InventoryItem>();
        static InventoryService()
        {
            InventoryItems.Add(new InventoryItem(new Car("Lamborghini", "Urraco",
                VehicleEnvironment.Land, "Lambo-Uracco.JPG", 4, 260.0, DriverSide.Left,
                new Review(4, "The Lamborghini Urraco was a sports car manufactured by " +
                              "Italian automaker Lamborghini in the 1970s. It was " +
                              "introduced at the Turin auto show in 1970 but wasn't " +
                              "available to buyers until 1973. It was named after a " +
                              "breed of bulls.")), 5));

            InventoryItems.Add(new InventoryItem(new Aeroplane("Boeing", "787 Dreamliner",
                VehicleEnvironment.Air, "Boeing-787.jpg", 4, 16, 300, 1600), 2));

            InventoryItems.Add(new InventoryItem(new Boat("Sea Ray", "410 Sundancer",
                VehicleEnvironment.Sea, null, 2, 106.5f, 24,
                "Sports Yacht with a difference - the Sea Ray 410 Sundancer is a " +
                "best in class ...."), 1));

            InventoryItems.Add(new InventoryItem(new Car("Ferrari", "458 Italia",
                VehicleEnvironment.Land, "Ferrari458.jpg", 4, 325.0, DriverSide.Left,
                new Review(4, "The 458 won \"Car of the Year 2009\" and \"Supercar of " +
                              "the Year\". It also won \"Cabrio of the Year 2011\" for " +
                              "the Spider, from Top Gear magazine. Auto Zeitung magazine " +
                              "awarded Ferrari 458 Spider \"Best Cabrio 2011\". Motor " +
                              "Trend awarded the Ferrari 458 Italia with the title of " +
                              "\"Best Driver's Car\" in 2011.")), 3));

            InventoryItems.Add(new InventoryItem(new Car("Aston Martin", "DB9",
                VehicleEnvironment.Land, "AstonMartinDB9.jpg", 4, 299.0, DriverSide.Left,
                new Review(4, "The Aston Martin DB9 is a grand tourer first shown by " +
                              "Aston Martin at the 2003 Frankfurt Auto Show. Available both as a " +
                              "coupe and a convertible, the DB9 was the successor of the DB7. " +
                              "It was the first model built at Aston Martin's Gaydon facility. " +
                              "The DB9, designed by Ian Callum and Henrik Fisker, is made " +
                              "largely of aluminium. The chassis is the VH platform, also " +
                              "found in the Aston Martin DBS. The engine, on the other hand, " +
                              "is the 6.0L V12 from the Aston Martin V12 Vanquish. The most " +
                              "recent Aston Martin has a top speed of 295 km/h (183 mph) and " +
                              "a 0 to 97 km/h (60 mph) time of 4.1 seconds. The DB9 is rated " +
                              "well by car critics, who appreciate the car's interior and " +
                              "exterior design. Additionally, in spite of the DB9's weaker " +
                              "engine and handling, reviewers liked the car's ride and driving " +
                              "experience. They held issue with the DB9's small rear seats and " +
                              "cargo space and poor satnav, however. Aston Martin Racing has " +
                              "adapted the DB9 for sports car racing, producing the DBR9 for " +
                              "FIA GT1 and the DBRS9 for FIA GT3. These two cars are lightened " +
                              "DB9s; the interior features are removed and the aluminium body " +
                              "panels are replaced by carbon fibre panels. Additionally, engine " +
                              "has been tweaked in both the cars to produce more horsepower. " +
                              "The DBR9 has won in several events, including its debut event.")), 7));

            InventoryItems.Add(new InventoryItem(new Car("Reliant", "Robin",
                VehicleEnvironment.Land, "ReliantRobin.jpg", 3, 46.0, DriverSide.Left,
                new Review(4, "The Robin was first manufactured in October 1973, a direct " +
                              "replacement for the Reliant Regal. The final original " +
                              "version of the Robin rolled off the production line in 1981, " +
                              "when the model was replaced by the restyled Reliant Rialto. " +
                              "The vehicle was also produced under license in Greece by MEBEA " +
                              "between 1974 and 1978. It was also manufactured in India by " +
                              "Sunrise Automotive Industries Limited as Badal. In 1989, " +
                              "Reliant revived the Robin name, producing a new and totally " +
                              "revamped Robin featuring a new fibreglass body, and increased " +
                              "engine power. The Rialto continued in production alongside the " +
                              "new Robin until 1998. This Robin was facelifted again in 1999 " +
                              "when the final version was launched that had its biggest change " +
                              "since originally launched with completely new panels, and Vauxhall " +
                              "Corsa front lamps. Designed as a hatchback-only model it lasted " +
                              "until February 2001 when Reliant announced the end of production. " +
                              "The final sixty-five Robins designed in 1999 manufactured by " +
                              "Reliant formed a Special Edition known as the Robin 65, featuring " +
                              "leather trim, walnut interior, and a numbered plaque, and sold for " +
                              "approximately £10,000. Manufacturing of the Robin resumed under " +
                              "licence by a company called B&N Plastics in July 2001, but stopped " +
                              "in October 2002. Despite its size, by being a three-wheeler with " +
                              "an official mass below 450 kg (992 lb), the Robin can be driven " +
                              "by holders of a B1 category driving licence in the United Kingdom, " +
                              "and registered and taxed at motorcycle rates, which gives a saving " +
                              "of 55 GBP per year over a conventional car. The single wheel in " +
                              "the front steers, while the engine (also in the front) drives the " +
                              "rear axle. Despite the car's reputation for being unstable, a 2011 " +
                              "survey reported that Reliant Robin owners were statistically " +
                              "Britain's safest drivers.")), 9));
        }

        public IEnumerable<InventoryItem> GetItems()
        {
            return InventoryItems.AsReadOnly();
        }
    }
}