namespace Inventory.Core.InventoryModels
{
    public class Review
    {
        public Review(int rating, string reviewText)
        {
            ReviewText = reviewText;
            Rating = rating;
        }

        public int Rating { get; private set; }
        public string ReviewText { get; private set; }
    }

}
