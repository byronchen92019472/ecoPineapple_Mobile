namespace Xaminals.Models
{
    public class Product
    {
        public string Name { get; set; }
        public string Details { get; set; }
        public string ImageSource { get; set; }
        public decimal ListedCost { get; set; }
        public decimal ActualCost { get; set; }
        public string Supplier { get; set; }
    }
}
