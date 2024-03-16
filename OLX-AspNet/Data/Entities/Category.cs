namespace OLX_AspNet.Data.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Item> Items  { get; set;}
    }
}