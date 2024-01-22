namespace OLX_AspNet.Data.Entities
{
    public class Item
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Address { get; set; }
        public string? Image { get; set; }
        public DateTime Time { get; set; }

    }
}
